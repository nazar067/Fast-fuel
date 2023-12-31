using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Canvas miniMap;

    public Button startButton;
    public Button pauseButton;

    public GameObject gameCanvas;
    public GameObject menuCanvas;
    public GameObject car;

    public Camera mainCamera;
    public Camera menuCamera;
    public Camera miniMapCamera;

    public bool changeScaleOnPressed = true;

    public Interstitial ad;
    public Reward rAd;

    [HideInInspector]
    public bool buttonPressed = false;
    RectTransform rectTransform;
    Vector3 initialScale;
    float scaleDownMultiplier = 1.2f;
    private void Start()
    {
        startButton.onClick.AddListener(GameStart);
        rectTransform = GetComponent<RectTransform>();
        initialScale = rectTransform.localScale;
        rAd.LoadAd();
    }

    private void GameStart()
    {
        mainCamera.gameObject.SetActive(true);       
        menuCanvas.SetActive(false);
        gameCanvas.SetActive(true);
        menuCamera.gameObject.SetActive(false);
        car.GetComponent<Animator>().enabled = false;
        pauseButton.gameObject.SetActive(true);
        miniMapCamera.gameObject.SetActive(true);
        miniMap.gameObject.SetActive(true);
    }
    public void ButtonDown()
    {
        buttonPressed = true;
        if (changeScaleOnPressed)
        {
            rectTransform.localScale = initialScale * scaleDownMultiplier;
        }
    }

    public void ButtonUp()
    {
        buttonPressed = false;
        if (changeScaleOnPressed)
        {
            rectTransform.localScale = initialScale;
        }
    }
}
