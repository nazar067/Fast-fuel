using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour
{
    public Button restartButton;
    public bool changeScaleOnPressed = true;
    [HideInInspector]
    public bool buttonPressed = false;
    RectTransform rectTransform;
    Vector3 initialScale;
    float scaleDownMultiplier = 1.2f;


    private void Start()
    {
        restartButton.onClick.AddListener(Restart);
        rectTransform = GetComponent<RectTransform>();
        initialScale = rectTransform.localScale;
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
