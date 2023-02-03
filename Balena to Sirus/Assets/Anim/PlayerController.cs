using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEditor.Build;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public float speedBoost;
    private float maxSpeed;
    private float normaleSpeed;
    private float halfSpeed;
    public double speedDecay = 0.95;
    public float speedLimit;
    public float speedBoostTimer;
    private float speedBoostCount;

    private Rigidbody _rb;
    public static bool IsBoosted;
    //calling animator
    private Animator anim;
    
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
        halfSpeed = playerSpeed / 2f;
        //getting animator component
        anim = gameObject.GetComponent<Animator>();
        //Debug.Log("Player Half Speed is " + halfSpeed.ToString());
    }


    private void Update()
    {
        if (IsBoosted)
        {
            playerSpeed = maxSpeed;
            speedBoostCount--;
        }

        if (speedBoostCount == 0f)
        {
            IsBoosted = false;
            playerSpeed = normaleSpeed;
        }

        if (Hide.isHiding == true)
         {
             playerSpeed = halfSpeed;
         }
         else
         {
             playerSpeed = normaleSpeed;
         }
        
         Debug.Log(_rb.velocity.magnitude);
         if (_rb.velocity.magnitude > speedLimit)
         {
             _rb.velocity = Vector3.ClampMagnitude(_rb.velocity, speedLimit);
         }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //If whale is moving bool in Animator set true = play swim
        anim.SetBool("IsSwimming", true);

        if (moveHorizontal == 0f && moveVertical == 0f)
        {
            _rb.velocity = _rb.velocity * (float)speedDecay;
            //if whale is not moving set bool to false = play idle
            anim.SetBool("IsSwimming", false);
        }

        _rb.AddForce(movement * playerSpeed);
    }
}

