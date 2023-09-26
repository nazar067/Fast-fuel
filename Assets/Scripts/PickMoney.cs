using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickMoney : MonoBehaviour
{
    public GameObject car;
    public int moneyValue = 1;

    private float newPositionX;
    private float newPositionZ;
    void Update()
    {
        this.gameObject.transform.Rotate(0, 0, 20 * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == car)
        {
            Destroy(this.gameObject);
            Spawn();
            Money.Instance.IncreaseMoney(moneyValue);
        }
    }
    private void Spawn()
    {
        newPositionX = car.transform.position.x + Random.Range(-5, 10);
        newPositionZ = car.transform.position.z + Random.Range(-5, 10);
        if (this.gameObject != null)
        {
            GameObject money = Instantiate(this.gameObject);
            money.transform.position = new Vector3(newPositionX, 0.1f, newPositionZ);
            Money script = money.GetComponent<Money>();
            if (script != null)
            {
                script.enabled = true;
            }
        }


    }
}
