using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickMoney : MonoBehaviour
{
    public GameObject car;
    public int moneyValue = 1;
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

        if (this.gameObject != null)
        {
            GameObject money = Instantiate(this.gameObject);
            money.transform.position = new Vector3(Random.Range(0f, 10f), 0.1f, Random.Range(0f, 10f));
            Money script = money.GetComponent<Money>();
            if (script != null)
            {
                script.enabled = true;
            }
        }


    }
}
