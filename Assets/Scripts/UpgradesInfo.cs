using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UpgradesInfo : MonoBehaviour
{
    public EventSystem eventSystem;
    public GameObject panelInfo;

    public Button infoFuel;
    public Button infoMaxSpeed;
    public Button infoMaxReverseSpeed;
    public Button infoAccelerationSpeed;
    public Button infoMaxSteeringAngle;
    public Button infoSteeringSpeed;
    public Button infoBrakeForce;
    public Button infoDeceleration;
    public Button infoDrift;
    public Button closePanel;

    public Text infoText;
    private LanguageText languageText;
    void Start()
    {
        infoFuel.onClick.AddListener(delegate { UpgradeInfo("fuelInfo"); });
        infoMaxSpeed.onClick.AddListener(delegate { UpgradeInfo("maxSpeedInfo"); });
        infoMaxReverseSpeed.onClick.AddListener(delegate { UpgradeInfo("maxReverseSpeedInfo"); });
        infoAccelerationSpeed.onClick.AddListener(delegate { UpgradeInfo("accelerationSpeedInfo"); });
        infoMaxSteeringAngle.onClick.AddListener(delegate { UpgradeInfo("MaxSteeringAngleInfo"); });
        infoSteeringSpeed.onClick.AddListener(delegate { UpgradeInfo("SteeringSpeedInfo"); });
        infoBrakeForce.onClick.AddListener(delegate { UpgradeInfo("brakeForceInfo"); });
        infoDeceleration.onClick.AddListener(delegate { UpgradeInfo("DecelerationInfo"); });
        infoDrift.onClick.AddListener(delegate { UpgradeInfo("DriftInfo"); });
        closePanel.onClick.AddListener(ClosePanel);

        languageText = eventSystem.GetComponent<LanguageText>();
    }

    void Update()
    {
        if (languageText != null)
        {
            string enText = languageText.text[0];
        }
    }
    public void UpgradeInfo(string detail)
    {
        panelInfo.SetActive(true);
        switch (detail)
        {
            case "fuelInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "Fuel consumption, the lower the number, " +
                        "the slower the fuel will be consumed(minimum 2)";
                }
                else if(languageText.language == 1)
                {
                    infoText.text = "������ �������, ��� ������ �����, " +
                        "��� ��������� ����� ������������� ������� (������� 2)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "������� ������, ��� ����� �����, " +
                        "��� �������� ���� ����������� ������(����� 2)";
                }
                break;
            case "maxSpeedInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "The value of maximum speed, the higher it is, " +
                        "the higher the maximum speed of the machine(maximum 190)";
                }
                else if (languageText.language == 1)
                {
                    infoText.text = "��� ������ �������� ������������ ��������, ��� ��� ����, " +
                        "��� ���� ������������ �������� ������(������������ 190)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "�������� ����������� ��������, ��� ���� ����, " +
                        "��� ����� ����������� �������� ������ (�������� 190)";
                }
                break;
            case "maxReverseSpeedInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "Maximum speed, but in reverse(maximum 120)";
                }
                else if (languageText.language == 1)
                {
                    infoText.text = "������������ ��������, �� ����� (�������� 120)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "����������� ��������, ��� ����� ����� (�������� 120)";
                }
                break;
            case "accelerationSpeedInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "The acceleration speed of the car, in simple terms, " +
                        "how many seconds it will accelerate from 0 to 100(maximum 10)";
                }
                else if(languageText.language == 1)
                {
                    infoText.text = "�������� ������� ����������, ����� ������, " +
                        "�� ������� ������ �� ���������� �� 0 �� 100 (�������� 10)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "�������� ������� ���������, ������� ������, " +
                        "�� ������ ������ �� ������������ �� 0 �� 100 (�������� 10)";
                }
                break;
            case "MaxSteeringAngleInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "Maximum steering angle of the car, the bigger it is, " +
                        "the better the car will turn and enter the corner (maximum 45).";
                }
                else if(languageText.language == 1)
                {
                    infoText.text = "������������ ���� �������� ����������, ��� �� ������, " +
                        "��� ����� ���������� ����� ������������ � ������� � ������� (�������� 45).";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "������������ ��� �������� ���������, ��� �� ������, " +
                        "��� ����� ��������� ���� ������������ � ������� � ������� (�������� 45).";
                }
                break;
            case "SteeringSpeedInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "Cornering speed, how fast the car will enter the corner, " +
                        "the higher the value the better control(maximum 1)";
                }
                else if (languageText.language == 1)
                {
                    infoText.text = "�������� ����������� ���������, � ����� ��������� ���������� ����� ������� � �������, " +
                        "��� ���� ��������, ��� ����� ���������� (�������� 1)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "�������� ����������� ��������, �� ������ ��������� ���� ������� � �������, " +
                        "��� ����� ��������, ��� ����� ���������(�������� 1)";
                }
                break;
            case "brakeForceInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "Handbrake force, the higher the value, " +
                        "the faster the car will stop(maximum 600)";
                }
                else if (languageText.language == 1)
                {
                    infoText.text = "���� ������� �������, ��� ������ ��������, " +
                        "��� ������� ����������� ���������� (�������� 600)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "���� ������� ������, ��� ����� ��������, " +
                        "��� ������ ��������� ���������� (�������� 600)";
                }
                break;
            case "DecelerationInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "Braking force, the higher the value, " +
                        "the faster the car will stop(maximum 10)";
                }
                else if (languageText.language == 1)
                {
                    infoText.text = "���� ����������, ��� ������ ��������, " +
                        "��� ������� ����������� ���������� (�������� 10)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "�������� ����, ��� ����� ��������, " +
                        "��� ������ ���������� ��������� (�������� 10)";
                }
                break;
            case "DriftInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "An indication of how much the car will skid (maximum 10)";
                }
                else if (languageText.language == 1)
                {
                    infoText.text = "���������� ������� ������ ���������� (�� ����� 10)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "������� �� ��, �������� ������ ��������� ���� �������� (�������� 10)";
                }
                break;
        }
    }
    public void ClosePanel()
    {
        panelInfo.SetActive(false);
    }
}
