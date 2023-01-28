using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI_Script : MonoBehaviour
{

    public void BackToMainMenu()
    {
        Debug.Log("Returning to Main Menu");
        SceneManager.LoadScene("MainMenu");

    }
    
    public void LevelSelectButton()
    {
        SceneManager.LoadScene("LevelSelect");
        
    }
   
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
    
}
