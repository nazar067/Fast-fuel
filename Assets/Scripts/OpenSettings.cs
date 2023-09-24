using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenSettings : MonoBehaviour
{
    public GameObject SettingsCanvas;
    public GameObject MenuCanvas;
    public Button SettingsButton;
    public Button CloseButton;

    private void Start()
    {
        SettingsButton.onClick.AddListener(Open);
        CloseButton.onClick.AddListener(Close);
    }
    private void Open()
    {
        MenuCanvas.SetActive(false);
        SettingsCanvas.SetActive(true);
    }
    private void Close()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
