using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIscript : MonoBehaviour
{

    public void StartButton()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
