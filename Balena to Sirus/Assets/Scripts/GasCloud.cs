using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasCloud : MonoBehaviour
{
    public float gasDamage;

    public bool playerInGas;

    public Health playerHealth;

    private void Start()
    {
        playerInGas = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInGas == true)
        {
            Health.health -= gasDamage * Time.deltaTime;
        }
    }
    

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInGas = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInGas = false;
        }
    }
}
