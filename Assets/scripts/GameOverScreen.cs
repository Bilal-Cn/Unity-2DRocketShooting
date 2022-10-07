using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public AudioSource click;

    public void Retry()
    {
        click.Play();
        SceneManager.LoadScene(1);
        
    }

    public void MainMenu()
    {
        click.Play();
        SceneManager.LoadScene(0);
    }
}
