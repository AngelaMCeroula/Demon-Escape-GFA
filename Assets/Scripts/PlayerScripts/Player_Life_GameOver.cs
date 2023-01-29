using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player_Life_GameOver : MonoBehaviour
{
    public int lives = 3 ; // number of lives
    public Transform startPosition;
    public UI_Lives _livesUi;


    private void Start()
    {
        _livesUi = GameObject.Find("Lives_Display_img").GetComponent<UI_Lives>();
        
    }

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
                lives --;
                transform.position = startPosition.transform.position;
                

            }
        }
        
    }
    
    
    

}
