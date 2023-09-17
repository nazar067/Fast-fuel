using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Button openShopButton;
    public Button closeShopButton;
    public Button upgradeFuelButton;
    public Button upgradeMaxSpeedButton;
/*    public Button upgradeMaxReverseSpeedButton;
    public Button upgradeAccelerationSpeedButton; //ускорение
    public Button upgradeMaxSteeringAngleButton; //угол поворота
    public Button upgradeSteeringSpeedButton; // скорость поворота
    public Button upgradeBrakeForceButton; // ручной тормоз
    public Button upgradeDecelerationButton; // тормоз
    public Button upgradeDriftButton; */
    public GameObject shopCanvas;
    public GameObject menuCanvas;
    void Start()
    {
        openShopButton.onClick.AddListener(OpenShop);
        closeShopButton.onClick.AddListener(CloseShop);
        upgradeFuelButton.onClick.AddListener(UpgradeFuel);
        upgradeMaxSpeedButton.onClick.AddListener(delegate { UpgradeCar("maxSpeed"); });
    }
    private void OpenShop()
    {
        shopCanvas.SetActive(true);
        menuCanvas.SetActive(false);
    }
    private void CloseShop()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void UpgradeFuel()
    {
        Upgrades.Instance.UpgradeFuel();
    }
    private void UpgradeCar(string detail)
    {
        PrometeoCarController.instance.UpgradesCar(detail);
    }
}
