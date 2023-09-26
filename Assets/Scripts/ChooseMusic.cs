using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChooseMusic : MonoBehaviour
{
    public List<AudioClip> musicTracks;

    public Slider volumeSlider; 

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayRandomMusic();
        audioSource.volume = PlayerPrefs.GetFloat("volume", 1);
        volumeSlider.value = PlayerPrefs.GetFloat("volumeSlider", audioSource.volume);
        //volumeSlider.value = audioSource.volume;

        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }
    void ChangeVolume(float volume)
    {
        audioSource.volume = volume;
        PlayerPrefs.SetFloat("volumeSlider", audioSource.volume);
        PlayerPrefs.SetFloat("volume", audioSource.volume);
    }
    void PlayRandomMusic()
    {
        if (musicTracks.Count > 0)
        {
            // �������� ��������� ������ �� ������.
            int randomIndex = Random.Range(0, musicTracks.Count);
            AudioClip randomMusic = musicTracks[randomIndex];

            // ����������� ��������� ������ AudioSource � ������������� �.
            audioSource.clip = randomMusic;
            audioSource.Play();

            // ����� ��������� ��������������� ������� ������, �������� ������� ��� ��������������� ����� ��������� ������.
            StartCoroutine(PlayRandomMusicAfterDelay(randomMusic.length));
        }
    }

    IEnumerator PlayRandomMusicAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        PlayRandomMusic();
    }
}
