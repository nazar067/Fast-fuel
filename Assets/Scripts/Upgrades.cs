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
    public Text maxSpeedText;
/*    public Text maxReverseSpeedText;
    public Text accelerationMultiplierText;
    public Text maxSteeringAngleText;
    public Text steeringSpeedText;
    public Text brakeForceText;
    public Text decelerationMultiplierText;
    public Text handbrakeDriftMultiplierText;*/

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
        if (fuelDepletionRate >= 2f && Money.Instance.money >= 10) { 
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
    public void UpgradeCarText(string detail)
    {
        switch(detail)
        {
            case "maxSpeed":
                maxSpeedText.text = "Max speed rate: " + PrometeoCarController.instance.maxSpeed
                    .ToString("F0");
                break;
        }
    }
}
