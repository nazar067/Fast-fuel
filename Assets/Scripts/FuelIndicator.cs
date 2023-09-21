using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelIndicator : MonoBehaviour
{
    public GameObject restartButton;
    public GameObject adResumeButton;
    public static FuelIndicator Instance;

    private float currentFuel; 
    public Text fuelText;
    private float startingFuel;
    private float fuelDepletionRate;

    private void Start()
    {
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
            restartButton.SetActive(true);
            adResumeButton.SetActive(true);
        }

        UpdateFuelText(); 
    }
    public void AddFuel(int countFuel)
    {
        currentFuel += countFuel;
        UpdateFuelText();
    }
    private void UpdateFuelText()
    {
        if (fuelText != null)
        {
            fuelText.text = "Fuel: " + currentFuel.ToString("F0");
        }
    }
}
