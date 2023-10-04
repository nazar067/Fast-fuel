using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    public GameObject car;
    public int scoreValue = 1;
    public int addFuelCount = 15;

    /*private float newPositionX;
    private float newPositionZ;*/
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
            new Vector3(11.2f, 0.1f, 7.4f)
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
        /*        newPositionX = car.transform.position.x + Random.Range(-5, 10);
                newPositionZ = car.transform.position.z + Random.Range(-5, 10);*/
        randIndex = Random.Range(0, vectorList.Count);
        if(this.gameObject != null)
        {
            GameObject fuel = Instantiate(this.gameObject);
            fuel.transform.position = vectorList[randIndex];/*new Vector3(newPositionX, 0.1f, newPositionZ);*/
            Fuel script = fuel.GetComponent<Fuel>();
            if (script != null)
            {
                script.enabled = true;
            }
        }
    }
}
