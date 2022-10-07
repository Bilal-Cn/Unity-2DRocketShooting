using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen2 : MonoBehaviour
{
    public void Retry()
    {

        SceneManager.LoadScene(2);

    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
