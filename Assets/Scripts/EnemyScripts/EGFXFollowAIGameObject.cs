using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EGFXFollowAIGameObject : MonoBehaviour
{
    public Transform EnemyBehaviourGameObject;
    public Vector3 offset; 

    // Update is called once per frame
    void Update()
    {
        // Camera follows the player with specified offset position
        transform.position = new Vector3(EnemyBehaviourGameObject.position.x + offset.x, EnemyBehaviourGameObject.position.y + offset.y, offset.z);

    }
}
