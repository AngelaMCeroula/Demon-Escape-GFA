using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Lives : MonoBehaviour
{
    public Sprite[] _liveSprites;
    public Image _LivesImage;
    private int currentLives;
    private Player_Life_GameOver gOver;
    
    
    
    
    private void Start()
    {
        //gOver = gameObject.Find("Player").GetComponent<Player_Life_GameOver>();
        currentLives = gOver.lives;

    }

    public void updateLives(int currentLives)
    {
        _LivesImage.sprite = _liveSprites[currentLives];
    }
    
}
