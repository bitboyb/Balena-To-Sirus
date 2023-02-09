using System;
using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using UnityEngine.UI;
using FMODUnity;


public class Health : MonoBehaviour
{
    public static float health = 100;
    private float maxHealth = 100;
    public EventReference death;
    private playerdamage life;
    public bool died;

    public Slider healthSlider;
    //public Text healthText;
    
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    
    }

    public void Start()
    {
        died = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        //healthText.text = "Health:" + health.ToString();
        UpdateHealthBar();
        if (health > maxHealth)
            health = maxHealth;
        {
            
        }
        if (health <= 0)
        {
            RuntimeManager.PlayOneShot(death);
            _rb.transform.position = CheckPoint.GetActiveCheckPointPoisition();
            health = maxHealth;
        }

        
    }

    void UpdateHealthBar()
    {
        healthSlider.value = health;
    }
}
