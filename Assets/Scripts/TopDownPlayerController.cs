using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownPlayerController : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection; 

    // Update is called once per frame
    void Update()
    {
        // calls for input
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        //uses Unity's axis input keys "The GetAxis page describes in detail what the axisName for GetAxisRaw means. For example the Horizontal axis is managed by Left and Right, and a and d keys. Other Input Axes can be seen in the Edit->Settings->Input window."
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }
   

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

    }
}
