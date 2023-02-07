using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altCrystal : MonoBehaviour
{
    public float addTime = 10f;
    

    public playerwarp playerWarp;
    public altCrystalRespawn aCrystalRespawn;


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerWarp.universeSwitchTimer = playerWarp.universeSwitchTime;
            Destroy(gameObject);
            aCrystalRespawn.altCrystalDestoryed = true;
        }
    }
}
