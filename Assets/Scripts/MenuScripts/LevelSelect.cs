using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject levelSelectCanvas;
    private void Start()
    {
        
    }

    public void Level0()
    {
        SceneManager.LoadScene("Level_0_Attic");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level_1_GroundFloor");

    }
    
    public void Level2()
    {
        SceneManager.LoadScene("Level_2_Basement");

    }
    
    public void Level3()
    {
        SceneManager.LoadScene("Level_3_Catacombs");

    }

    public void EndCredits()
    {
        SceneManager.LoadScene("FinalCredits");
    }
    
    public void ReturnToMainMenu()
    {
        mainMenuCanvas.SetActive(true);
        levelSelectCanvas.SetActive(false);
    }

    public void Return()
    {
        SceneManager.LoadScene("MainMenu"); 
        
    }
}
