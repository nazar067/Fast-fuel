using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    public GameObject car;
    public int scoreValue = 1;
    public int addFuelCount = 15;
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

        if(this.gameObject != null)
        {
            GameObject fuel = Instantiate(this.gameObject);
            fuel.transform.position = new Vector3(Random.Range(0f, 10f), 0.1f, Random.Range(0f, 10f));
            Fuel script = fuel.GetComponent<Fuel>();
            if (script != null)
            {
                script.enabled = true;
            }
        }


    }
}
