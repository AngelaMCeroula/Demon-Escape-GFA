using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Lives : MonoBehaviour
{
    //public Sprite[] _liveSprites;
    //public Image _livesImage;
    public int currentLives;
    private Player_Life_GameOver gOver;

    public GameObject imgLives1, imgLives2, imgLives3;
    
    
    private void Start()
    {
        gOver = GameObject.Find("Player").GetComponent<Player_Life_GameOver>();
        currentLives = gOver.lives;
        imgLives1.gameObject.SetActive(false);
        imgLives2.gameObject.SetActive(false);
        imgLives3.gameObject.SetActive(true);
        
    }
    

    private void Update()
    {
        currentLives = gOver.lives;
        if (currentLives > 3)
            currentLives = 3;

        switch (currentLives)
        {
            case 3:
            {
                imgLives1.gameObject.SetActive(true);
                imgLives2.gameObject.SetActive(true);
                imgLives3.gameObject.SetActive(true);
                break;
            }
            
            
            case 2:
            {
                imgLives1.gameObject.SetActive(true);
                imgLives2.gameObject.SetActive(true);
                imgLives3.gameObject.SetActive(false);
                break;
            }
            
            case 1:
            {
                imgLives1.gameObject.SetActive(true);
                imgLives2.gameObject.SetActive(false);
                imgLives3.gameObject.SetActive(false);
                break;
            }
            


        }



    }
}
