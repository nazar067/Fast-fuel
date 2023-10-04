using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    public GameObject car;
    public int scoreValue = 1;
    public int addFuelCount = 15;

    private int randIndex;
    private List<Vector3> vectorList;

    private void Start()
    {
        vectorList = new List<Vector3>
        {
            new Vector3(-2, 0.1f, 2),
            new Vector3(1.7f, 0.1f, -8),
            new Vector3(3.4f, 0.1f, 5.6f),
            new Vector3(-2.5f, 0.1f, 5.6f),
            new Vector3(-2.5f, 0.1f, 11.3f),
            new Vector3(1.3f, 0.1f, 17.8f),
            new Vector3(4.5f, 0.1f, 24.8f),
            new Vector3(16.1f, 0.1f, 28.7f),
            new Vector3(17f, 0.1f, 18.3f),
            new Vector3(11.2f, 0.1f, 7.4f),
            new Vector3(-7.9f, 0.1f, 3.9f),
            new Vector3(-14.6f, 0.1f, 7.9f),
            new Vector3(-21.6f, 0.1f, 14.7f),
            new Vector3(-7f, 0.1f, 29f),
            new Vector3(-3.3f, 0.1f, 24f),
            new Vector3(-6.5f, 0.1f, 31f),
            new Vector3(-11.5f, 0.1f, 33.5f),
            new Vector3(-19.5f, 0.1f, 38.4f),
            new Vector3(1.4f, 0.1f, 37.4f),
            new Vector3(3.7f, 0.1f, 31f),
            new Vector3(9.9f, 0.1f, 33.3f),
            new Vector3(19.8f, 0.1f, 38f),
            new Vector3(16f, 0.1f, -0.5f),
            new Vector3(22.1f, 0.1f, -6.8f),
            new Vector3(16.6f, 0.1f, -9f),
            new Vector3(11f, 0.1f, -15.6f),
            new Vector3(5.7f, 0.1f, -9.9f),
            new Vector3(-5.6f, 0.1f, -17f),
            new Vector3(-10.8f, 0.1f, -10.9f),
            new Vector3(-18.7f, 0.1f, -15.7f),
            new Vector3(-16.2f, 0.1f, -7.1f),
            new Vector3(-22f, 0.1f, -3.4f),
            new Vector3(-17.1f, 0.1f, 3.3f),
            new Vector3(-19.4f, 0.1f, -26.4f),
            new Vector3(-13f, 0.1f, -21.6f),
            new Vector3(3.9f, 0.1f, -24.1f),
            new Vector3(10f, 0.1f, -24.1f),
            new Vector3(14.9f, 0.1f, -25.3f),
            new Vector3(22f, 0.1f, -23.4f),
        };
    }
    void Update()
    {
        this.gameObject.transform.Rotate(0, 20 * Time.deltaTime, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == car)
        {
            Destroy(this.gameObject);
            Spawn();
            Score.Instance.IncreaseScore(scoreValue);
            FuelIndicator.Instance.AddFuel(addFuelCount);
        }
    }
    private void Spawn()
    {
        randIndex = Random.Range(0, vectorList.Count);
        if(this.gameObject != null)
        {
            GameObject fuel = Instantiate(this.gameObject);
            fuel.transform.position = vectorList[randIndex];
            Fuel script = fuel.GetComponent<Fuel>();
            if (script != null)
            {
                script.enabled = true;
            }
            Outline outlineScript = fuel.GetComponent<Outline>();
            if(outlineScript != null)
            {
                outlineScript.enabled = true;
            }
        }
    }
}
