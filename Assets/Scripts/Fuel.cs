using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    public GameObject car;
    public int scoreValue = 1;
    public int addFuelCount = 15;

    private float newPositionX;
    private float newPositionZ;
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
        newPositionX = car.transform.position.x + Random.Range(-5, 10);
        newPositionZ = car.transform.position.z + Random.Range(-5, 10);
        if(this.gameObject != null)
        {
            GameObject fuel = Instantiate(this.gameObject);
            fuel.transform.position = new Vector3(newPositionX, 0.1f, newPositionZ);
            Fuel script = fuel.GetComponent<Fuel>();
            if (script != null)
            {
                script.enabled = true;
            }
        }


    }
}
