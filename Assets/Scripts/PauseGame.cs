using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    public AudioSource fuelSound;
    public Button pauseButton;
    public Button resumeButton;
    public Button exitButton;
    public GameObject pauseCanvas;
    public GameObject carButtons;
    private bool isPaused = false;

    private void Start()
    {
        pauseButton.onClick.AddListener(Pause);
        exitButton.onClick.AddListener(Pause);
        resumeButton.onClick.AddListener(Pause);
    }
    private void Update()
    {
        if (isPaused)
        {
            PrometeoCarController.instance.carEngineSound.mute = true;
        }
        if(!isPaused)
        {
            PrometeoCarController.instance.useSounds = true;
        }
    }
    public void Pause()
    {
        isPaused = !isPaused;


        if (isPaused)
        {
            pauseButton.gameObject.SetActive(false);
            pauseCanvas.SetActive(true);
            carButtons.SetActive(false);
            fuelSound.mute = true;
        }
        else
        {
            pauseCanvas.SetActive(false);
            carButtons.SetActive(true);
            pauseButton.gameObject.SetActive(true);
            if(FuelIndicator.Instance.CurrentFuel() <= 30)
            {
                fuelSound.mute = false;
            }
        }
        Time.timeScale = isPaused ? 0 : 1;
    }
}
