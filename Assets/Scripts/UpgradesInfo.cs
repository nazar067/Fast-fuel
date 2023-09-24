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
                    infoText.text = "Расход топлива, чем меньше число, " +
                        "тем медленнее будет расходоваться топливо (минимум 2)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Витрата палива, чим менше число, " +
                        "тим повільніше буде витрачатися паливо(мінімум 2)";
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
                    infoText.text = "Чем больше значение максимальной скорости, тем она выше, " +
                        "тем выше максимальная скорость машины(максимальная 190)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Значення максимальної швидкості, чим вона вища, " +
                        "тим більша максимальна швидкість машини (максимум 190)";
                }
                break;
            case "maxReverseSpeedInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "Maximum speed, but in reverse(maximum 120)";
                }
                else if (languageText.language == 1)
                {
                    infoText.text = "Максимальная скорость, но задом (максимум 120)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Максимальна швидкість, але заднім ходом (максимум 120)";
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
                    infoText.text = "Скорость разгона автомобиля, проще говоря, " +
                        "за сколько секунд он разгонится от 0 до 100 (максимум 10)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Швидкість розгону автомобіля, простіше кажучи, " +
                        "за скільки секунд він розганяється від 0 до 100 (максимум 10)";
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
                    infoText.text = "Максимальный угол поворота автомобиля, чем он больше, " +
                        "тем лучше автомобиль будет поворачивать и входить в поворот (максимум 45).";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Максимальний кут повороту автомобіля, чим він більший, " +
                        "тим краще автомобіль буде розвертатися і входити в поворот (максимум 45).";
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
                    infoText.text = "Скорость прохождения поворотов, с какой скоростью автомобиль будет входить в поворот, " +
                        "чем выше значение, тем лучше управление (максимум 1)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Швидкість проходження повороту, як швидко автомобіль буде входити в поворот, " +
                        "чим більше значення, тим краще керування(максимум 1)";
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
                    infoText.text = "Сила ручного тормоза, чем больше значение, " +
                        "тем быстрее остановится автомобиль (максимум 600)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Сила ручного гальма, чим більше значення, " +
                        "тим швидше автомобіль зупиниться (максимум 600)";
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
                    infoText.text = "Сила торможения, чем больше значение, " +
                        "тем быстрее остановится автомобиль (максимум 10)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Гальмівна сила, чим більше значення, " +
                        "тим швидше зупиниться автомобіль (максимум 10)";
                }
                break;
            case "DriftInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "An indication of how much the car will skid (maximum 10)";
                }
                else if (languageText.language == 1)
                {
                    infoText.text = "Показатель степени заноса автомобиля (не более 10)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Вказівка на те, наскільки сильно автомобіль буде заносити (максимум 10)";
                }
                break;
        }
    }
    public void ClosePanel()
    {
        panelInfo.SetActive(false);
    }
}
