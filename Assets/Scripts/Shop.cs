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
    public GameObject shopCanvas;
    public GameObject menuCanvas;
    void Start()
    {
        openShopButton.onClick.AddListener(OpenShop);
        closeShopButton.onClick.AddListener(CloseShop);
        upgradeFuelButton.onClick.AddListener(UpgradeFuel);
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
}
