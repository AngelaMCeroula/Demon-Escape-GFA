using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Script: MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject levelSelectCanvas;
    public void StartButton()
    {
        SceneManager.LoadScene("Level_0_Attic");
    }

    public void LevelSelectButton()
    {
        //SceneManager.LoadScene("LevelSelect");
        levelSelectCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);

    }

    public void Quit()
    {
        Application.Quit();
    }
}
