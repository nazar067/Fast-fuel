using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeLanguage : MonoBehaviour
{
    public Button enButton, rusButton, ukrButton;

    public Image currentLanguage;

    public Sprite en, rus, ukr;

    public int language;

    private void Start()
    {
        language = PlayerPrefs.GetInt("language", language);

        enButton.onClick.AddListener(EnglishLanguage);
        rusButton.onClick.AddListener(RussianLanguage);
        ukrButton.onClick.AddListener(UkrainianLanguage);
    }
    private void Update()
    {
        if(language == 0)
        {
            currentLanguage.sprite = en;
        }
        else if(language == 1)
        {
            currentLanguage.sprite = rus;
        }
        else if(language == 2)
        {
            currentLanguage.sprite = ukr;
        }
    }
    public void EnglishLanguage()
    {
        language = 0;
        PlayerPrefs.SetInt("language", language);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void RussianLanguage()
    {
        language = 1;
        PlayerPrefs.SetInt("language", language);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void UkrainianLanguage()
    {
        language = 2;
        PlayerPrefs.SetInt("language", language);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
