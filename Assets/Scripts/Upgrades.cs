using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public static Upgrades Instance;

    public float startingFuel = 150f;
    public float fuelDepletionRate = 7f;

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
        fuelDepletionRate = PlayerPrefs.GetInt("fuelRate", 7);
    }
    public void UpgradeFuel()
    {
        if (fuelDepletionRate > 2f && Money.Instance.money >= 40)
        {
            fuelDepletionRate -= 1f;
            Money.Instance.MinusMoney(40);
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
            if (languageText.language == 0)
            {
                fuelRate.text = "Fuel Efficiency: " + fuelDepletionRate.ToString("F0");
            }
            else if(languageText.language == 1)
            {
                fuelRate.text = "������ �������: " + fuelDepletionRate.ToString("F0");
            }
            else if (languageText.language == 2)
            {
                fuelRate.text = "������� ��������: " + fuelDepletionRate.ToString("F0");
            }
        }
    }
    public void UpgradeCarText(string detail)
    {
        switch (detail)
        {
            case "maxSpeed":
                if(languageText.language == 0)
                {
                    maxSpeedText.text = "Maximum Speed: \n" + PrometeoCarController.instance.maxSpeed
                        .ToString("F0") + "/190";
                }
                else if (languageText.language == 1)
                {
                    maxSpeedText.text = "������������ ��������: \n" + PrometeoCarController.instance.maxSpeed
                        .ToString("F0") + "/190";
                }
                else if (languageText.language == 2)
                {
                    maxSpeedText.text = "����������� ��������: \n" + PrometeoCarController.instance.maxSpeed
                        .ToString("F0") + "/190";
                }
                break;
            case "maxReverseSpeed":
                if (languageText.language == 0)
                {
                    maxReverseSpeedText.text = "Reverse Speed: \n" + PrometeoCarController.instance.maxReverseSpeed
                        .ToString("F0") + "/120";
                }
                else if(languageText.language == 1)
                {
                    maxReverseSpeedText.text = "�������� �����: \n" + PrometeoCarController.instance.maxReverseSpeed
                        .ToString("F0") + "/120";
                }
                else if (languageText.language == 2)
                {
                    maxReverseSpeedText.text = "�������� �������� ����: \n" + PrometeoCarController.instance.maxReverseSpeed
                        .ToString("F0") + "/120";
                }
                break;
            case "accelerationSpeed":
                if (languageText.language == 0)
                {
                    accelerationMultiplierText.text = "Acceleration Speed: \n" + PrometeoCarController.instance.accelerationMultiplier
                        .ToString("F0") + "/10";
                }
                else if (languageText.language == 1)
                {
                    accelerationMultiplierText.text = "�������� �������: \n" + PrometeoCarController.instance.accelerationMultiplier
                        .ToString("F0") + "/10";
                }
                else if (languageText.language == 2)
                {
                    accelerationMultiplierText.text = "�������� �������: \n" + PrometeoCarController.instance.accelerationMultiplier
                        .ToString("F0") + "/10";
                }
                break;
            case "maxSteeringAngle":
                if (languageText.language == 0)
                {
                    maxSteeringAngleText.text = "Turning Angle: \n" + PrometeoCarController.instance.maxSteeringAngle
                        .ToString("F0") + "/45";
                }
                else if (languageText.language == 1)
                {
                    maxSteeringAngleText.text = "���� ��������: \n" + PrometeoCarController.instance.maxSteeringAngle
                        .ToString("F0") + "/45";
                }
                else if (languageText.language == 2)
                {
                    maxSteeringAngleText.text = "��� ��������: \n" + PrometeoCarController.instance.maxSteeringAngle
                        .ToString("F0") + "/45";
                }
                break;
            case "steeringSpeed":
                if (languageText.language == 0)
                {
                    steeringSpeedText.text = "Turn Entry Speed: \n" + PrometeoCarController.instance.steeringSpeed
                        .ToString() + "/1";
                }
                else if (languageText.language == 1)
                {
                    steeringSpeedText.text = "�������� ��������: \n" + PrometeoCarController.instance.steeringSpeed
                        .ToString() + "/1";
                }
                else if (languageText.language == 2)
                {
                    steeringSpeedText.text = "�������� ����� � �������: \n" + PrometeoCarController.instance.steeringSpeed
                        .ToString() + "/1";
                }
                break;
            case "brakeForce":
                if (languageText.language == 0)
                {
                    brakeForceText.text = "Handbrake Force: \n" + PrometeoCarController.instance.brakeForce
                        .ToString("F0") + "/600";
                }
                else if (languageText.language == 1)
                {
                    brakeForceText.text = "���� ������� �������: \n" + PrometeoCarController.instance.brakeForce
                        .ToString("F0") + "/600";
                }
                else if (languageText.language == 2)
                {
                    brakeForceText.text = "���� ������� ������: \n" + PrometeoCarController.instance.brakeForce
                        .ToString("F0") + "/600";
                }
                break;
            case "deceleration":
                if (languageText.language == 0)
                {
                    decelerationMultiplierText.text = "Brake Force: \n" + PrometeoCarController.instance.decelerationMultiplier
                        .ToString("F0") + "/10";
                }
                else if(languageText.language == 1)
                {
                    decelerationMultiplierText.text = "���� ��������: \n" + PrometeoCarController.instance.decelerationMultiplier
                        .ToString("F0") + "/10";
                }
                else if (languageText.language == 2)
                {
                    decelerationMultiplierText.text = "���� �����: \n" + PrometeoCarController.instance.decelerationMultiplier
                        .ToString("F0") + "/10";
                }
                break;
            case "drift":
                if (languageText.language == 0)
                {
                    handbrakeDriftMultiplierText.text = "Drift Quality: \n" + PrometeoCarController.instance.handbrakeDriftMultiplier
                        .ToString("F0") + "/10";
                }
                else if (languageText.language == 1)
                {
                    handbrakeDriftMultiplierText.text = "�������� ������: \n" + PrometeoCarController.instance.handbrakeDriftMultiplier
                        .ToString("F0") + "/10";
                }
                else if (languageText.language == 2)
                {
                    handbrakeDriftMultiplierText.text = "����� ������: \n" + PrometeoCarController.instance.handbrakeDriftMultiplier
                        .ToString("F0") + "/10";
                }
                break;
        }
    }
}
