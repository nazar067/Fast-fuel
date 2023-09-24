using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLanguage : MonoBehaviour
{
    public int language;

    private void Start()
    {
        language = PlayerPrefs.GetInt("language", language);
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
