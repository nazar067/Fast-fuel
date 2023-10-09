using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelTankFade : MonoBehaviour
{
    public AudioSource fuelSound;
    public Image myImage;
    public float fadeDuration = 1.0f; // ƒлительность изменени€ прозрачности.

    private float elapsedTime = 0.0f;
    private bool increasingAlpha = true;
    private int sound;

    void Update()
    {
        sound = PlayerPrefs.GetInt("volumeSound");
        if(FuelIndicator.Instance.CurrentFuel() <= 30)
        {
            if(sound == 1)
            {
                fuelSound.mute = false;
                fuelSound.volume = 0.3f;
            }
            // ѕолучаем текущую прозрачность изображени€.
            float currentAlpha = myImage.color.a;

            // »нкрементируем или декрементируем прозрачность в зависимости от услови€.
            float alphaChange = Time.deltaTime / fadeDuration;
            myImage.color = new Color(myImage.color.r, myImage.color.g, myImage.color.b,
                                      Mathf.Clamp01(currentAlpha + (increasingAlpha ? alphaChange : -alphaChange)));

            // ќбновл€ем таймер и провер€ем, нужно ли изменить направление изменени€ прозрачности.
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= fadeDuration)
            {
                elapsedTime = 0.0f;
                increasingAlpha = !increasingAlpha;
            }
        }
        else if(FuelIndicator.Instance.CurrentFuel() > 30)
        {
            myImage.color = new Color(myImage.color.r, myImage.color.g, myImage.color.b, 255);
            fuelSound.mute = true;
        }
        if (FuelIndicator.Instance.CurrentFuel() <= 0)
        {
            fuelSound.mute = true;
        }
    }
}
