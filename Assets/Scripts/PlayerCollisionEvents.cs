using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionEvents: MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) // When player collides
    {
        if (collision.gameObject.tag == "Enemy") // if player collides with game objects tagged Enemy
        {
            Debug.Log("You have been caught");
            
        }
            
    }
    
}
