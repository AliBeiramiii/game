using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

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
    public void rematch()
    {   
        resume();
        SceneManager.LoadScene("Game");
        

    }

}
