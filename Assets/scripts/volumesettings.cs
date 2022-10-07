using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumesettings : MonoBehaviour
{
   

    public Slider musicSlider;
    public Slider volumeSlider;

    public AudioSource[] soundeffect;
    public AudioSource[] music;
  
    void Start()
    { 
        volumeSlider.value = PlayerPrefs.GetFloat("volume");
        musicSlider.value = PlayerPrefs.GetFloat("music");
    }

    
    void Update()
    {
        soundeffect[0].volume = volumeSlider.value;
        soundeffect[1].volume = volumeSlider.value;
        soundeffect[2].volume = volumeSlider.value;
        soundeffect[3].volume = volumeSlider.value;
        soundeffect[4].volume = volumeSlider.value;
        soundeffect[5].volume = volumeSlider.value;
        soundeffect[6].volume = volumeSlider.value;

        music[0].volume = musicSlider.value;
        music[1].volume = musicSlider.value;

    }
}
