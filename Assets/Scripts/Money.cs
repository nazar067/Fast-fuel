using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public static Money Instance;

    public Text moneyText;
    public Text moneyTextShop;

    public int money = 0;
    private void Start()
    {
        UpdateMoneyText();
    }

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
        money = PlayerPrefs.GetInt("Money", 0);
    }

    public void IncreaseMoney(int amount)
    {
        money += amount;
        UpdateMoneyText();
        PlayerPrefs.SetInt("Money", money);
    }
    public void MinusMoney(int amount)
    {
        if(money >= amount)
        {
            money -= amount;
            UpdateMoneyText();
            PlayerPrefs.SetInt("Money", money);
        }
        if(money < 0)
        {
            money = 0;
            UpdateMoneyText();
            PlayerPrefs.SetInt("Money", money);
        }
    }
    private void UpdateMoneyText()
    {
        if (moneyText != null)
        {
            moneyText.text = "Money: " + money.ToString();
            moneyTextShop.text = moneyText.text;
        }
    }
}
