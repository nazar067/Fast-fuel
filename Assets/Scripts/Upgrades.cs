using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public static Upgrades Instance;

    public float startingFuel = 100f;
    public float fuelDepletionRate = 10f;

    public Text fuelRate;

    private void Start()
    {
        UpdateFuelText();
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        fuelDepletionRate = PlayerPrefs.GetInt("fuelRate", 0);
    }
    public void UpgradeFuel()
    {
        if (fuelDepletionRate >= 2f) { 
            fuelDepletionRate -= 1f;
            Money.Instance.MinusMoney(10);
            PlayerPrefs.SetInt("fuelRate", Convert.ToInt32(fuelDepletionRate));
            UpdateFuelText();
        }
        if(fuelDepletionRate < 2)
        {
            fuelDepletionRate = 2f;
            PlayerPrefs.SetInt("fuelRate", Convert.ToInt32(fuelDepletionRate));
            UpdateFuelText();
        }
    }
    private void UpdateFuelText()
    {
        if (fuelRate != null)
        {
            fuelRate.text = "Fuel rate: " + fuelDepletionRate.ToString("F0");
        }
    }
}
