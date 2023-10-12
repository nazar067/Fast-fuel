using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score Instance;
    public EventSystem eventSystem;

    public Text scoreText;
    public Text highScoreText;

    private int score = 0;
    private int highScore = 0;

    private LanguageText languageText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            //Destroy(gameObject);
        }
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    private void Start()
    {
        languageText = eventSystem.GetComponent<LanguageText>();
        languageText.language = PlayerPrefs.GetInt("language", 0);

        UpdateScoreText();
        UpdateHighScoreText();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();

        // Проверяем, установлен ли новый рекорд.
        if (score > highScore)
        {
            highScore = score;
            // Сохраняем новый рекорд в PlayerPrefs.
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
        }
    }
    private void UpdateHighScoreText()
    {
        if (highScoreText != null)
        {
            if (languageText.language == 0)
            {
                highScoreText.text = "Top score: " + highScore.ToString();
            }
            else if(languageText.language == 1)
            {
                highScoreText.text = "Лучший результат: " + highScore.ToString();
            }
            else if(languageText.language == 2)
            {
                highScoreText.text = "Кращий результат: " + highScore.ToString();
            }
        }
    }
}
