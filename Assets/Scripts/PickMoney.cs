using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickMoney : MonoBehaviour
{
    private List<int> moneyList = new List<int>() { 1, 1, 2, 3, 3, 4, 5, 5, 6, 7, 8, 9, 10};  

    public GameObject car;
    public int moneyValue;

    private float newPositionX;
    private float newPositionZ;

    private void Awake()
    {
        int randMoney = Random.Range(0, moneyList.Count);
        moneyValue = moneyList[randMoney];
    }
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
