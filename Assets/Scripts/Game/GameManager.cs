using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;


    void Update()
    {
        
    }
    public void gameOver()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void tryAgain()
    {
        gameOverUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }
}
