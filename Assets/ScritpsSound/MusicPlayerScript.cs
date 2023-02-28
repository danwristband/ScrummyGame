using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayerScript : MonoBehaviour
{

    public Slider volumeSlider;
    public GameObject ObjectMusic;
    private float musicVolume = 1f;
    public AudioSource audioSource;

   
    
    private void Start()
    {
        ObjectMusic = GameObject.FindWithTag("GameMusic");
        audioSource = ObjectMusic.GetComponent<AudioSource>();

        //Set Volume
        musicVolume = PlayerPrefs.GetFloat("volume");
        audioSource.volume = musicVolume;
        volumeSlider.value = musicVolume;
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = musicVolume;
        PlayerPrefs.SetFloat("volume", musicVolume);
    }

    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }

    public void MusicReset()
    {
        PlayerPrefs.DeleteKey("volume");
        audioSource.volume = 1;
        volumeSlider.value = 1;
    }
}
