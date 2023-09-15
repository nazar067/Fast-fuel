using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Button startButton;
    public GameObject gameCanvas;
    public GameObject menuCanvas;
    public bool changeScaleOnPressed = true;
    [HideInInspector]
    public bool buttonPressed = false;
    RectTransform rectTransform;
    Vector3 initialScale;
    float scaleDownMultiplier = 1.2f;
    private void Start()
    {
        PrometeoCarController.instance.carEngineSound.mute = true;
        startButton.onClick.AddListener(GameStart);
        rectTransform = GetComponent<RectTransform>();
        initialScale = rectTransform.localScale;
    }

    private void GameStart()
    {
        menuCanvas.SetActive(false);
        gameCanvas.SetActive(true);
        PrometeoCarController.instance.carEngineSound.mute = false;
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
