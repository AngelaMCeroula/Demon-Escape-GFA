using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel_1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("Level_1_Complete", 1);
            SceneManager.LoadScene("EndLevel1");
         
        }
    }
}
