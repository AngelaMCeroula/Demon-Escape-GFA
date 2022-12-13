using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody2D _rb;
    Vector2 _playerInput;
    float _speed = 60f;


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        _playerInput = new Vector2(Input.GetAxisRaw("Horizontal") * _speed, Input.GetAxisRaw("Vertical") * _speed);
    }

    private void FixedUpdate()
    {
        _rb.AddForce(_playerInput);
    }
}
