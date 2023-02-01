using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public float speedBoost;
    private float maxSpeed;
    private float normaleSpeed;
    public float speedBoostTimer;
    private float speedBoostCount;

    private Rigidbody _rb;
    public static bool IsBoosted;
    
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        IsBoosted = false;
        maxSpeed = speedBoost;
        normaleSpeed = playerSpeed;
        speedBoostCount = speedBoostTimer;
    }


    private void Update()
    {
        if (IsBoosted == true)
        {
            playerSpeed = maxSpeed;
            speedBoostCount--;
        }

        if (speedBoostCount == 0f)
        {
            IsBoosted = false;
            playerSpeed = normaleSpeed;
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        _rb.AddForce(movement * playerSpeed);
    }
}
