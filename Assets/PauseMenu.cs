using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
<<<<<<< HEAD
    public static bool gameIsPauesed = false;
    public GameObject pauseMenuUI;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        if (gameIsPauesed)
        {
            resume();
        }
        else
        {
            pause();
        }
    }
    public void resume()
    {

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPauesed = false;
    }
    public void pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPauesed=true;
    }
    public void LoadingMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void QuitingGame()
    {
        Debug.Log("quiting game");
        Application.Quit();
    }
    
=======
   public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void StartAgain()
    {
        Debug.Log("Start Game...");
        Application.Quit(); 
    }
>>>>>>> c9d306a044e3534abdcf5d9f34b88fc0eafb1c5a
}
