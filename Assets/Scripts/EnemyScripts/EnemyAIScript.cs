using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyAIScript : MonoBehaviour
{
    
    public float radius = 5f;
    [Range(1,360)]public float angle = 90f;
    public LayerMask targetLayer;
    public LayerMask obstructionLayer;

    public Transform player;
    private GameObject playerReference;
    public bool CanSeePlayer { get; private set; }
    
  
    private float distance;
    public float runSpeed;
    
    
    
    
    void Start()
    {
        playerReference = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(FOVCheck());
        
    }

    private IEnumerator FOVCheck()
    {
        WaitForSeconds wait = new WaitForSeconds(0.2f);

        while (true)
        {
            yield return wait;
            FOV();
        }
    }


    private void FOV()
    {
        Collider2D[] rangeCheck = Physics2D.OverlapCircleAll(transform.position, radius, targetLayer);

        if (rangeCheck.Length > 0)
        {
            Transform target = rangeCheck[0].transform;
            Vector2 directionToTarget = (target.position - transform.position).normalized;

            if (Vector2.Angle(transform.up, directionToTarget) < angle / 2)
            {
                float distanceToTarget = Vector2.Distance(transform.position, target.position);

                if (!Physics2D.Raycast(transform.position, directionToTarget, distanceToTarget, obstructionLayer))
                {
                    CanSeePlayer = true;
                }

                else
                {
                    CanSeePlayer = false;
                }
                    
            }
            else
            {
                CanSeePlayer = false;
            }
        }
        else if (CanSeePlayer)
                CanSeePlayer = false;
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        UnityEditor.Handles.DrawWireDisc(transform.position,Vector3.forward, radius);

        Vector3 angle01 = DirectionFromAngle(-transform.eulerAngles.z, -angle / 2);
        Vector3 angle02 = DirectionFromAngle(-transform.eulerAngles.z, angle / 2);
        
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, transform.position + angle01 * radius);
        Gizmos.DrawLine(transform.position, transform.position + angle02 * radius);

        if (CanSeePlayer)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, playerReference.transform.position);
        }
        Vector2 DirectionFromAngle(float eulerY, float angleInDegrees)
        {
            angleInDegrees += eulerY;
            return new Vector2(Mathf.Sin(angleInDegrees* Mathf.Deg2Rad), Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
        }
    }
    



    private void Update()
    {
        if (CanSeePlayer == true)
        {
            AiChase();
        }
        else
        {
            return;
        }
        void AiChase()
        {
            
            float step = runSpeed * Time.deltaTime;

            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, step);
            transform.up = player.position - transform.position;
           
           
            
        }
    }

    
    
}





