using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sounds : MonoBehaviour
{
    public Button soundButton, soundButtonPause;
    public Button musicButton, musicButtonPause;

    public Sprite mus_on, mus_off;
    public Sprite sound_on, sound_off;

    public AudioSource musics;

    public Slider volumeSlider;


    private int sound = 1;
    private int music = 1;
    void Start()
    {
        sound = PlayerPrefs.GetInt("sound", 1);
        music = PlayerPrefs.GetInt("music", 1);

        PrometeoCarController.instance.carEngineSound.volume = PlayerPrefs.GetFloat("volumeSound", 1);
        PrometeoCarController.instance.tireScreechSound.volume = PlayerPrefs.GetFloat("volumeSound", 1);
        volumeSlider.value = PlayerPrefs.GetFloat("volumeSoundSlider", PrometeoCarController.instance.carEngineSound.volume);

        soundButton.onClick.AddListener(Sound);
        soundButtonPause.onClick.AddListener(Sound);

        musicButton.onClick.AddListener(Music);
        musicButtonPause.onClick.AddListener(Music);

        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }
    void ChangeVolume(float volume)
    {
        PrometeoCarController.instance.carEngineSound.volume = volume;
        PrometeoCarController.instance.tireScreechSound.volume = volume;
        PlayerPrefs.SetFloat("volumeSoundSlider", PrometeoCarController.instance.carEngineSound.volume);
        PlayerPrefs.SetFloat("volumeSound", PrometeoCarController.instance.carEngineSound.volume);
    }
    private void Update()
    {
        if (sound == 1)
        {
            PrometeoCarController.instance.carEngineSound.mute = false;
            PrometeoCarController.instance.tireScreechSound.mute = false;

            soundButton.GetComponent<Image>().sprite = sound_on;
            soundButtonPause.GetComponent<Image>().sprite = sound_on;
        }
        if(sound == 0)
        {
            PrometeoCarController.instance.carEngineSound.mute = true;
            PrometeoCarController.instance.tireScreechSound.mute = true;

            soundButton.GetComponent<Image>().sprite = sound_off;
            soundButtonPause.GetComponent<Image>().sprite = sound_off;
        }
        if(music == 1)
        {
            musics.mute = false;

            musicButton.GetComponent<Image>().sprite = mus_on;
            musicButtonPause.GetComponent<Image>().sprite = mus_on;
        }
        if (music == 0)
        {
            musics.mute = true;

            musicButton.GetComponent<Image>().sprite = mus_off;
            musicButtonPause.GetComponent<Image>().sprite = mus_off;
        }
    }
    private void Sound()
    {
        if (sound == 1)
        {
            sound = 0;
            PlayerPrefs.SetInt("sound", sound);
        }
        else if (sound == 0)
        {
            sound = 1;
            PlayerPrefs.SetInt("sound", sound);
        }
    }
    private void Music()
    {
        if (music == 1)
        {
            music = 0;
            PlayerPrefs.SetInt("music", music);
        }
        else if (music == 0)
        {
            music = 1;
            PlayerPrefs.SetInt("music", music);
        }
    }
}
