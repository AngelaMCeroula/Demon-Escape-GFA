using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Player_Life_GameOver : MonoBehaviour
{
    public int lives = 3 ; // number of lives
    public Transform startPosition;

    private void Update()
    {
        if (lives < 1)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
            
        }
    }


    private void OnCollisionEnter2D(Collision2D enterCollision)
    {
        if (enterCollision.gameObject.CompareTag("Enemy"))
        { 
            Debug.Log("You have been caught");
           
            if (lives >= 1)
            {
                lives -= 1;
                transform.position = startPosition.transform.position;

            }
        }
        
    }
    

}
