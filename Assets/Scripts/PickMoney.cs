using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickMoney : MonoBehaviour
{
    private List<int> moneyList = new List<int>() { 1, 1, 2, 3, 3, 4, 5, 5, 6, 7, 8, 9, 10};

    public GameObject car;
    public int moneyValue;

    private int randIndex;
    private List<Vector3> vectorList;

    private void Start()
    {
        vectorList = new List<Vector3>
        {
            new Vector3(-2.2f, 0.1f, 2),
            new Vector3(2f, 0.1f, -8),
            new Vector3(3.8f, 0.1f, 5.6f),
            new Vector3(-2.8f, 0.1f, 5.6f),
            new Vector3(-2.3f, 0.1f, 11.3f),
            new Vector3(1.5f, 0.1f, 17.8f),
            new Vector3(4.8f, 0.1f, 24.8f),
            new Vector3(16.5f, 0.1f, 28.7f),
            new Vector3(17.3f, 0.1f, 18.3f),
            new Vector3(11.5f, 0.1f, 7.4f),
            new Vector3(-7.6f, 0.1f, 3.9f),
            new Vector3(-14.2f, 0.1f, 7.9f),
            new Vector3(-21.5f, 0.1f, 14.7f),
            new Vector3(-7.3f, 0.1f, 29f),
            new Vector3(-3.1f, 0.1f, 24f),
            new Vector3(-6.7f, 0.1f, 31f),
            new Vector3(-11.8f, 0.1f, 33.5f),
            new Vector3(-19.8f, 0.1f, 38.4f),
            new Vector3(1.7f, 0.1f, 37.4f),
            new Vector3(3.3f, 0.1f, 31f),
            new Vector3(9.6f, 0.1f, 33.3f),
            new Vector3(19.6f, 0.1f, 38f),
            new Vector3(16.3f, 0.1f, -0.5f),
            new Vector3(22.3f, 0.1f, -6.8f),
            new Vector3(16.9f, 0.1f, -9f),
            new Vector3(11.2f, 0.1f, -15.6f),
            new Vector3(5.4f, 0.1f, -9.9f),
            new Vector3(-5.26f, 0.1f, -17f),
            new Vector3(-10.5f, 0.1f, -10.9f),
            new Vector3(-18.4f, 0.1f, -15.7f),
            new Vector3(-16.6f, 0.1f, -7.1f),
            new Vector3(-22.4f, 0.1f, -3.4f),
            new Vector3(-17.4f, 0.1f, 3.3f),
            new Vector3(-19.7f, 0.1f, -26.4f),
            new Vector3(-13.4f, 0.1f, -21.6f),
            new Vector3(3.6f, 0.1f, -24.1f),
            new Vector3(10.3f, 0.1f, -24.1f),
            new Vector3(14.6f, 0.1f, -25.3f),
            new Vector3(22.3f, 0.1f, -23.4f),
        };
    }

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
        randIndex = Random.Range(0, vectorList.Count);
        if (this.gameObject != null)
        { 
            GameObject money = Instantiate(this.gameObject);
            money.transform.position = vectorList[randIndex];
            Money script = money.GetComponent<Money>();
            if (script != null)
            {
                script.enabled = true;
            }
            Outline outlineScript = money.GetComponent<Outline>();
            if (outlineScript != null)
            {
                outlineScript.enabled = true;
            }
            PickMoney pickScript = money.GetComponent<PickMoney>();
            if (pickScript != null)
            {
                pickScript.enabled = true;
            }
        }


    }
}
