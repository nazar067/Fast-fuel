using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score Instance;

    public Text scoreText;
    public Text highScoreText;

    private int score = 0;
    private int highScore = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    private void Start()
    {
        UpdateScoreText();
        UpdateHighScoreText();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();

        // ���������, ���������� �� ����� ������.
        if (score > highScore)
        {
            highScore = score;
            // ��������� ����� ������ � PlayerPrefs.
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
    private void UpdateHighScoreText()
    {
        if (highScoreText != null)
        {
            highScoreText.text = "HighScore: " + highScore.ToString();
        }
    }
}
