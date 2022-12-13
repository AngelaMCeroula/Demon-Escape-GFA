using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUI_Script : MonoBehaviour
{
   
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
    
}
