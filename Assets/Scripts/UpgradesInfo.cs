using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesInfo : MonoBehaviour
{
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
    }

    void Update()
    {
        
    }
    public void UpgradeInfo(string detail)
    {
        panelInfo.SetActive(true);
        switch (detail)
        {
            case "fuelInfo":
                infoText.text = "Fuel consumption, the lower the number, " +
                    "the slower the fuel will be consumed(minimum 2)";
                break;
            case "maxSpeedInfo":
                infoText.text = "The value of maximum speed, the higher it is, " +
                    "the higher the maximum speed of the machine(maximum 190)";
                break;
            case "maxReverseSpeedInfo":
                infoText.text = "Maximum speed, but in reverse(maximum 120)";
                break;
            case "accelerationSpeedInfo":
                infoText.text = "The acceleration speed of the car, in simple terms, " +
                    "how many seconds it will accelerate from 0 to 100(maximum 10)";
                break;
            case "MaxSteeringAngleInfo":
                infoText.text = "Maximum steering angle of the car, the bigger it is, " +
                    "the better the car will turn and enter the corner (maximum 45).";
                break;
            case "SteeringSpeedInfo":
                infoText.text = "Cornering speed, how fast the car will enter the corner, " +
                    "the higher the value the better control(maximum 1)";
                break;
            case "brakeForceInfo":
                infoText.text = "Handbrake force, the higher the value, " +
                    "the faster the car will stop(maximum 600)";
                break;
            case "DecelerationInfo":
                infoText.text = "Braking force, the higher the value, " +
                    "the faster the car will stop(maximum 10)";
                break;
            case "DriftInfo":
                infoText.text = "An indication of how much the car will skid (maximum 10)";
                break;
        }
    }
    public void ClosePanel()
    {
        panelInfo.SetActive(false);
    }
}
