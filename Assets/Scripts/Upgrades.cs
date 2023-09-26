using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public static Upgrades Instance;

    public float startingFuel = 100f;
    public float fuelDepletionRate = 10f;

    public EventSystem eventSystem;

    public Text fuelRate;
    public Text maxSpeedText;
    public Text maxReverseSpeedText;
    public Text accelerationMultiplierText;
    public Text maxSteeringAngleText;
    public Text steeringSpeedText;
    public Text brakeForceText;
    public Text decelerationMultiplierText;
    public Text handbrakeDriftMultiplierText;

    private LanguageText languageText;

    void Start()
    {
        languageText = eventSystem.GetComponent<LanguageText>();
        languageText.language = PlayerPrefs.GetInt("language", 0);

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
                if(languageText.language == 0)
                {
                    maxSpeedText.text = "Max speed rate: \n" + PrometeoCarController.instance.maxSpeed
                        .ToString("F0") + "/190";
                }
                else if (languageText.language == 1)
                {
                    maxSpeedText.text = "Максимальная скорость: \n" + PrometeoCarController.instance.maxSpeed
                        .ToString("F0") + "/190";
                }
                else if (languageText.language == 2)
                {
                    maxSpeedText.text = "Максимальна швидкість: \n" + PrometeoCarController.instance.maxSpeed
                        .ToString("F0") + "/190";
                }
                break;
            case "maxReverseSpeed":
                if (languageText.language == 0)
                {
                    maxReverseSpeedText.text = "Max reverse speed rate: \n" + PrometeoCarController.instance.maxReverseSpeed
                        .ToString("F0") + "/120";
                }
                else if(languageText.language == 1)
                {
                    maxReverseSpeedText.text = "Скорость задом: \n" + PrometeoCarController.instance.maxReverseSpeed
                        .ToString("F0") + "/120";
                }
                else if (languageText.language == 2)
                {
                    maxReverseSpeedText.text = "Задня швидкість: \n" + PrometeoCarController.instance.maxReverseSpeed
                        .ToString("F0") + "/120";
                }
                break;
            case "accelerationSpeed":
                if (languageText.language == 0)
                {
                    accelerationMultiplierText.text = "Acceleration speed rate: \n" + PrometeoCarController.instance.accelerationMultiplier
                        .ToString("F0") + "/10";
                }
                else if (languageText.language == 1)
                {
                    accelerationMultiplierText.text = "Скорость разгона: \n" + PrometeoCarController.instance.accelerationMultiplier
                        .ToString("F0") + "/10";
                }
                else if (languageText.language == 2)
                {
                    accelerationMultiplierText.text = "Швидкість розгону: \n" + PrometeoCarController.instance.accelerationMultiplier
                        .ToString("F0") + "/10";
                }
                break;
            case "maxSteeringAngle":
                if (languageText.language == 0)
                {
                    maxSteeringAngleText.text = "Max Steering Angle rate: \n" + PrometeoCarController.instance.maxSteeringAngle
                        .ToString("F0") + "/45";
                }
                else if (languageText.language == 1)
                {
                    maxSteeringAngleText.text = "Угол поворота: \n" + PrometeoCarController.instance.maxSteeringAngle
                        .ToString("F0") + "/45";
                }
                else if (languageText.language == 2)
                {
                    maxSteeringAngleText.text = "Кут повороту: \n" + PrometeoCarController.instance.maxSteeringAngle
                        .ToString("F0") + "/45";
                }
                break;
            case "steeringSpeed":
                if (languageText.language == 0)
                {
                    steeringSpeedText.text = "Steering speed rate: \n" + PrometeoCarController.instance.steeringSpeed
                        .ToString("F0") + "/1";
                }
                else if (languageText.language == 1)
                {
                    steeringSpeedText.text = "Скорость поворота: \n" + PrometeoCarController.instance.steeringSpeed
                        .ToString("F0") + "/1";
                }
                else if (languageText.language == 2)
                {
                    steeringSpeedText.text = "Швидкість повороту: \n" + PrometeoCarController.instance.steeringSpeed
                        .ToString("F0") + "/1";
                }
                break;
            case "brakeForce":
                if (languageText.language == 0)
                {
                    brakeForceText.text = "Brake Force rate: \n" + PrometeoCarController.instance.brakeForce
                        .ToString("F0") + "/600";
                }
                else if (languageText.language == 1)
                {
                    brakeForceText.text = "Сила ручного тормоза: \n" + PrometeoCarController.instance.brakeForce
                        .ToString("F0") + "/600";
                }
                else if (languageText.language == 2)
                {
                    brakeForceText.text = "Якість ручного гальма: \n" + PrometeoCarController.instance.brakeForce
                        .ToString("F0") + "/600";
                }
                break;
            case "deceleration":
                if (languageText.language == 0)
                {
                    decelerationMultiplierText.text = "Deceleration rate: \n" + PrometeoCarController.instance.decelerationMultiplier
                        .ToString("F0") + "/10";
                }
                else if(languageText.language == 1)
                {
                    decelerationMultiplierText.text = "Сила тормозов: \n" + PrometeoCarController.instance.decelerationMultiplier
                        .ToString("F0") + "/10";
                }
                else if (languageText.language == 2)
                {
                    decelerationMultiplierText.text = "Сила гальма: \n" + PrometeoCarController.instance.decelerationMultiplier
                        .ToString("F0") + "/10";
                }
                break;
            case "drift":
                if (languageText.language == 0)
                {
                    handbrakeDriftMultiplierText.text = "Drift rate: \n" + PrometeoCarController.instance.handbrakeDriftMultiplier
                        .ToString("F0") + "/10";
                }
                else if (languageText.language == 1)
                {
                    handbrakeDriftMultiplierText.text = "Качество дрифта: \n" + PrometeoCarController.instance.handbrakeDriftMultiplier
                        .ToString("F0") + "/10";
                }
                else if (languageText.language == 2)
                {
                    handbrakeDriftMultiplierText.text = "Якість дрифту: \n" + PrometeoCarController.instance.handbrakeDriftMultiplier
                        .ToString("F0") + "/10";
                }
                break;
        }
    }
}
