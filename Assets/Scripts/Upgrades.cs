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
    public Text maxReverseSpeedText;
    public Text accelerationMultiplierText;
    public Text maxSteeringAngleText;
    public Text steeringSpeedText;
    public Text brakeForceText;
    public Text decelerationMultiplierText;
    public Text handbrakeDriftMultiplierText;

    private void Start()
    {
        UpdateFuelText();
        UpgradeCarText("maxSpeed");
        UpgradeCarText("maxReverseSpeed");
        UpgradeCarText("accelerationSpeed");
        UpgradeCarText("maxSteeringAngle");
        UpgradeCarText("steeringSpeed");
        UpgradeCarText("brakeForce");
        UpgradeCarText("deceleration");
        UpgradeCarText("drift");
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
        if (fuelDepletionRate > 2f && Money.Instance.money >= 10)
        {
            fuelDepletionRate -= 1f;
            Money.Instance.MinusMoney(10);
            PlayerPrefs.SetInt("fuelRate", Convert.ToInt32(fuelDepletionRate));
            UpdateFuelText();
        }
        if (fuelDepletionRate < 2)
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
        switch (detail)
        {
            case "maxSpeed":
                maxSpeedText.text = "Max speed rate: \n" + PrometeoCarController.instance.maxSpeed
                    .ToString("F0") + "/190";
                break;
            case "maxReverseSpeed":
                maxReverseSpeedText.text = "Max reverse speed rate: \n" + PrometeoCarController.instance.maxReverseSpeed
                    .ToString("F0") + "/120";
                break;
            case "accelerationSpeed":
                accelerationMultiplierText.text = "Acceleration speed rate: \n" + PrometeoCarController.instance.accelerationMultiplier
                    .ToString("F0") + "/10";
                break;
            case "maxSteeringAngle":
                maxSteeringAngleText.text = "Max Steering Angle rate: \n" + PrometeoCarController.instance.maxSteeringAngle
                    .ToString("F0") + "/45";
                break;
            case "steeringSpeed":
                steeringSpeedText.text = "Steering speed rate: \n" + PrometeoCarController.instance.steeringSpeed
                    .ToString("F0") + "/1";
                break;
            case "brakeForce":
                brakeForceText.text = "Brake Force rate: \n" + PrometeoCarController.instance.brakeForce
                    .ToString("F0") + "/600";
                break;
            case "deceleration":
                decelerationMultiplierText.text = "Deceleration rate: \n" + PrometeoCarController.instance.decelerationMultiplier
                    .ToString("F0") + "/10";
                break;
            case "drift":
                handbrakeDriftMultiplierText.text = "Drift rate: \n" + PrometeoCarController.instance.handbrakeDriftMultiplier
                    .ToString("F0") + "/10";
                break;
        }
    }
}
