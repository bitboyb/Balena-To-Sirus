using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static float health = 100;
    private float maxHealth = 100;

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

        if (health <= 0)
        {
            _rb.transform.position = CheckPoint.GetActiveCheckPointPoisition();
            health = maxHealth;
        }

        
    }

    void UpdateHealthBar()
    {
        healthSlider.value = health;
    }
}
