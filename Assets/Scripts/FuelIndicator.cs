using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelIndicator : MonoBehaviour
{
    public GameObject loseCanvas;
    public GameObject carButtons;
    public GameObject pauseButton;
    public static FuelIndicator Instance;

    private float currentFuel;
    public Text fuelText;
    private float startingFuel;
    private float fuelDepletionRate;

    private void Start()
    {
        if (Upgrades.Instance != null)
        {
            startingFuel = Upgrades.Instance.startingFuel;
            fuelDepletionRate = Upgrades.Instance.fuelDepletionRate;
        }
        currentFuel = startingFuel;
        UpdateFuelText();
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
        if (Upgrades.Instance != null)
        {
            startingFuel = Upgrades.Instance.startingFuel;
            fuelDepletionRate = Upgrades.Instance.fuelDepletionRate;
        }
    }
    private void Update()
    {
        currentFuel -= fuelDepletionRate * Time.deltaTime;

        if (currentFuel <= 0)
        {
            currentFuel = 0;
            PrometeoCarController.instance.useSounds = false;
            PrometeoCarController.instance.useTouchControls = false;

            loseCanvas.SetActive(true);
            carButtons.SetActive(false);
            pauseButton.SetActive(false);
        }

        UpdateFuelText();
    }
    public void AddFuel(int countFuel)
    {
        currentFuel += countFuel;
        if (currentFuel > 150)
        {
            currentFuel = 150;
        }
        UpdateFuelText();
    }
    private void UpdateFuelText()
    {
        if (fuelText != null)
        {
            fuelText.text = currentFuel.ToString("F0");
        }
    }
    public float CurrentFuel()
    {
        return currentFuel;
    }
}
