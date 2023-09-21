using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    public Button pauseButton;
    public GameObject pauseCanvas;
    public GameObject carButtons;
    private bool isPaused = false;

    private void Start()
    {
        pauseButton.onClick.AddListener(Pause);
    }
    public void Pause()
    {
        isPaused = !isPaused;

        Time.timeScale = isPaused ? 0 : 1;

        if (isPaused)
        {
            pauseCanvas.SetActive(true);
            carButtons.SetActive(false);
            PrometeoCarController.instance.carEngineSound.mute = true;
        }
        else
        {
            pauseCanvas.SetActive(false);
            carButtons.SetActive(true);
            PrometeoCarController.instance.carEngineSound.mute = false;
        }
    }
}
