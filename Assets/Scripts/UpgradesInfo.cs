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
                    infoText.text = "Это улучшение снижает потребление топлива, " +
                        "позволяя вашей машине проезжать большее расстояние на одном баке.(минимум 2)";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Це покращення зменшує споживання пального, " +
                        "дозволяючи вашому автомобілю подолати більший шлях на одному баку.(мінімум 2)";
                }
                break;
            case "maxSpeedInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "Increase your car's maximum speed for a faster and more dynamic ride.";
                }
                else if (languageText.language == 1)
                {
                    infoText.text = "Увеличьте максимальную скорость вашего автомобиля для более быстрой и динамичной езды.";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Збільште максимальну швидкість свого автомобілю для швидкої та динамічної поїздки.";
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
                    infoText.text = "Это улучшение оптимизирует заднюю скорость вашей машины, " +
                        "обеспечивая лучшую маневренность в ограниченных пространствах.";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Це удосконалення оптимізує швидкість руху заднім ходом вашого автомобілю, " +
                        "забезпечуючи кращу маневреність в обмежених просторах.";
                }
                break;
            case "accelerationSpeedInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "Boost your car's acceleration speed for successful starts and efficient overtaking.";
                }
                else if(languageText.language == 1)
                {
                    infoText.text = "Повысьте скорость разгона вашего автомобиля для успешных стартов и эффективных обгонов.";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Підвищте швидкість розгону свого автомобілю для успішних стартів та ефективних обгонів.";
                }
                break;
            case "MaxSteeringAngleInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "Enhance your car's turning angle, making it more maneuverable when navigating turns.";
                }
                else if(languageText.language == 1)
                {
                    infoText.text = "Улучшьте угол поворота вашего автомобиля, делая его более маневренным при прохождении поворотов.";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Покращте кут повороту вашого автомобілю, роблячи його більш маневреним при проходженні поворотів.";
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
                    infoText.text = "Это улучшение увеличивает скорость захода вашего автомобиля в поворот, " +
                        "обеспечивая лучший контакт с дорогой и повышенную управляемость.";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Це удосконалення збільшує швидкість входу вашого автомобілю в поворот, " +
                        "забезпечуючи кращий контакт з дорогою та поліпшену керованість.";
                }
                break;
            case "brakeForceInfo":
                if(languageText.language == 0)
                {
                    infoText.text = "Increase the force of your handbrake for controlled and stylish drifts in challenging situations.";
                }
                else if (languageText.language == 1)
                {
                    infoText.text = " Увеличьте силу ручного тормоза для контролируемых и эффектных дрифтов в сложных ситуациях.";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Збільште силу ручного гальма для контрольованих і стильних дрифтів в складних ситуаціях.";
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
                    infoText.text = "Это улучшение увеличивает общую силу торможения, " +
                        "обеспечивая лучшее управление вашим автомобилем на высоких скоростях.";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Це покращення збільшує загальну силу гальмування, " +
                        "забезпечуючи кращий контроль вашого автомобілю на великих швидкостях.";
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
                    infoText.text = "Повысьте качество дрифта для точного и эффектного выполнения маневров. " +
                        "Это улучшение придаст новый характер вашим заездам.";
                }
                else if (languageText.language == 2)
                {
                    infoText.text = "Покращте якість ваших дрифтів для точних і стильних маневрів. " +
                        "Це удосконалення додасть новий вимір ваших заїздів.";
                }
                break;
        }
    }
    public void ClosePanel()
    {
        panelInfo.SetActive(false);
    }
}
