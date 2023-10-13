using System;
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

    private float score = 0;
    private float highScore = 0;

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
        highScore = PlayerPrefs.GetFloat("HighScore", 0);
    }

    private void Start()
    {
        languageText = eventSystem.GetComponent<LanguageText>();
        languageText.language = PlayerPrefs.GetInt("language", 0);

        UpdateScoreText();
        UpdateHighScoreText();
    }
    private void Update()
    {
        if (PrometeoCarController.instance.carSpeed > 1)
        {
            score += 3 * Time.deltaTime;
            UpdateScoreText();
            if (score > highScore)
            {
                highScore = score;
                // Сохраняем новый рекорд в PlayerPrefs.
                PlayerPrefs.SetFloat("HighScore", highScore);
            }
        }
        
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
            PlayerPrefs.SetFloat("HighScore", highScore);
        }
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = score.ToString("F0");
        }
    }
    private void UpdateHighScoreText()
    {
        if (highScoreText != null)
        {
            if (languageText.language == 0)
            {
                highScoreText.text = "Top score: " + highScore.ToString("F0");
            }
            else if (languageText.language == 1)
            {
                highScoreText.text = "Лучший результат: " + highScore.ToString("F0");
            }
            else if (languageText.language == 2)
            {
                highScoreText.text = "Кращий результат: " + highScore.ToString("F0");
            }
        }
    }
}
