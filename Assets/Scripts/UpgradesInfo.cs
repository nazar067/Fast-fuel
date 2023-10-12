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
    public void UpgradeInfo(string detail)
    {
        panelInfo.SetActive(true);
        switch (detail)
        {
            case "fuelInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "This upgrade reduces fuel consumption, " +
                        "allowing your car to cover more distance on a single tank.(minimum 2)";
                }
                else if(languageText.language == 1)
                {
                    infoText.text = "��� ��������� ������� ����������� �������, " +
                        "�������� ����� ������ ��������� ������� ���������� �� ����� ����.(������� 2)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "�� ���������� ������ ���������� ��������, " +
                        "���������� ������ ��������� �������� ������ ���� �� ������ ����.(����� 2)";
                }
                break;
            case "maxSpeedInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "Increase your car's maximum speed for a faster and more dynamic ride.";
                }
                else if (languageText.language == 1)
                {
                    infoText.text = "��������� ������������ �������� ������ ���������� ��� ����� ������� � ���������� ����.";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "������� ����������� �������� ����� ��������� ��� ������ �� �������� ������.";
                }
                break;
            case "maxReverseSpeedInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "This improvement optimizes your car's reverse speed, " +
                        "providing better maneuverability in confined spaces.";
                }
                else if (languageText.language == 1)
                {
                    infoText.text = "��� ��������� ������������ ������ �������� ����� ������, " +
                        "����������� ������ ������������� � ������������ �������������.";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "�� ������������� ������� �������� ���� ����� ����� ������ ���������, " +
                        "������������ ����� ����������� � ��������� ���������.";
                }
                break;
            case "accelerationSpeedInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "Boost your car's acceleration speed for successful starts and efficient overtaking.";
                }
                else if(languageText.language == 1)
                {
                    infoText.text = "�������� �������� ������� ������ ���������� ��� �������� ������� � ����������� �������.";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "ϳ������ �������� ������� ����� ��������� ��� ������� ������ �� ���������� ������.";
                }
                break;
            case "MaxSteeringAngleInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "Enhance your car's turning angle, making it more maneuverable when navigating turns.";
                }
                else if(languageText.language == 1)
                {
                    infoText.text = "�������� ���� �������� ������ ����������, ����� ��� ����� ����������� ��� ����������� ���������.";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "�������� ��� �������� ������ ���������, ������� ���� ���� ���������� ��� ���������� ��������.";
                }
                break;
            case "SteeringSpeedInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "This upgrade increases your car's speed when entering a turn, " +
                        "ensuring better road contact and improved handling.";
                }
                else if (languageText.language == 1)
                {
                    infoText.text = "��� ��������� ����������� �������� ������ ������ ���������� � �������, " +
                        "����������� ������ ������� � ������� � ���������� �������������.";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "�� ������������� ������ �������� ����� ������ ��������� � �������, " +
                        "������������ ������ ������� � ������� �� �������� ����������.";
                }
                break;
            case "brakeForceInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "Increase the force of your handbrake for controlled and stylish drifts in challenging situations.";
                }
                else if (languageText.language == 1)
                {
                    infoText.text = " ��������� ���� ������� ������� ��� �������������� � ��������� ������� � ������� ���������.";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "������� ���� ������� ������ ��� �������������� � �������� ������ � �������� ���������.";
                }
                break;
            case "DecelerationInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "This enhancement increases the overall brake force, " +
                        "providing better control of your car at high speeds.";
                }
                else if (languageText.language == 1)
                {
                    infoText.text = "��� ��������� ����������� ����� ���� ����������, " +
                        "����������� ������ ���������� ����� ����������� �� ������� ���������.";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "�� ���������� ������ �������� ���� �����������, " +
                        "������������ ������ �������� ������ ��������� �� ������� ����������.";
                }
                break;
            case "DriftInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "Improve the quality of your drifts for precise and stylish maneuvers. " +
                        "This upgrade will add a new dimension to your races.";
                }
                else if (languageText.language == 1)
                {
                    infoText.text = "�������� �������� ������ ��� ������� � ���������� ���������� ��������. " +
                        "��� ��������� ������� ����� �������� ����� �������.";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "�������� ����� ����� ������ ��� ������ � �������� �������. " +
                        "�� ������������� ������� ����� ���� ����� �����.";
                }
                break;
        }
    }
    public void ClosePanel()
    {
        panelInfo.SetActive(false);
    }
}
