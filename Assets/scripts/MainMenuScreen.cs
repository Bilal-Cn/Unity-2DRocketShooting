using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScreen : MonoBehaviour
{
    public GameObject exitMenu;
    public GameObject options;

    public AudioSource click;
    public AudioClip Click;

    public volumesettings volumesettings;

 
    public void Play()
    {
        click.PlayOneShot(Click,1);
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        click.PlayOneShot(Click, 1);
        exitMenu.SetActive(true);
    }

    public void Yes()
    {
        click.PlayOneShot(Click, 1);
        Application.Quit();
        Debug.Log("çıkış");
    }
    public void No()
    {
        click.PlayOneShot(Click, 1);
        exitMenu.SetActive(false);
    }

    public void Options()
    {
        click.PlayOneShot(Click, 1);
        options.SetActive(true);
    }

    public void yesIki()
    {
        PlayerPrefs.SetFloat("volume", volumesettings.volumeSlider.value);
        PlayerPrefs.SetFloat("music", volumesettings.musicSlider.value);
        click.PlayOneShot(Click, 1);
        options.SetActive(false);
    }

   
}
