using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingManager : MonoBehaviour
{
    public GameObject settingUI;
    public GameObject mainMenuUI;
    
    

    
    void Update()
    {
        
    }
    public void openSetting()
    {
        mainMenuUI.SetActive(false);
        settingUI.SetActive(true);

    }
    public void openMainMenu()
    {
        settingUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }
    public void playGame()
    {
        //mainMenuUI.SetActive(false);
        SceneManager.LoadScene("Game");
    }
}
