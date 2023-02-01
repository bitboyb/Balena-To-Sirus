using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public float speedBoost;
    public float speedBoostTimer;
    private float speedBoostCount;
    public static float currentSpeed;
    public float jumpForce;
    private Rigidbody _rb;
    private bool _isGrounded;
    private bool _isBoosted;
    
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        currentSpeed = playerSpeed;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        _rb.AddForce(movement * playerSpeed);
    }
}
