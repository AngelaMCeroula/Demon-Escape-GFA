using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyDirectionGfx : MonoBehaviour
{
    public AIPath aiPath;
    

    // Update is called once per frame
    void Update()
    {
        if (aiPath.desiredVelocity.x >= 0.01f) //if moving to the right
        {
            transform.localScale = new Vector3(-1f, 1f, 1f); // flips the sprite to the left
        }
        if (aiPath.desiredVelocity.x <= -0.01f) //if moving to the left
        {
            transform.localScale = new Vector3(1f, 1f, 1f); // flips the sprite to the right
        }

        if (aiPath.desiredVelocity.y <= -0.01f) //if moving down
        {
           
        }
        
        if (aiPath.desiredVelocity.y >= -0.01f) //if moving up
        {
            
        }
        
        

    }
}
