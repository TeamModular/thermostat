using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = new GameManager();

    // make sure the constructor is private, so it can only be instantiated here
    private GameManager() {}

    public static GameManager Instance {
        get { return instance; }
    }


    public bool Paused;

    public void SetPause(bool pause)
    {
        Paused = pause;
        if(Paused)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
 
}

