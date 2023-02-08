using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerwarp : MonoBehaviour
{
    public float universeSwitchTime = 10f;
    public float universeSwitchTimer;
    public float rechargeRefreshTimer = 3f;
    private float rechargeTimer;
    public float rechargeRate;
    

    public static bool altUniverse;
    private bool energyCharge;
    
    public GameObject shadowplayer;
    public GameObject player;

    public Slider timeShiftSlider;

    //public Text altUniText;

    public void SwitchPlayer()
    {
        var playerPos = player.transform.position;
        var shadowPos = shadowplayer.transform.position;

        player.transform.position = shadowPos;
        shadowplayer.transform.position = playerPos;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        universeSwitchTimer = universeSwitchTime;
        altUniverse = false;
        energyCharge = false;
        rechargeTimer = rechargeRefreshTimer;
    }

    // Update is called once per frame
    void Update()
    {
        //altUniText.text = "Time Left:" + universeSwitchTimer.ToString();
        timeShiftSlider.value = universeSwitchTimer;
        
        if (Input.GetKeyDown("e") && universeSwitchTimer > 0)
        {
            SwitchPlayer();
            //altUniverse = !altUniverse;
        }

        if (altUniverse)
        {
            universeSwitchTimer -= Time.deltaTime;
            if (universeSwitchTimer <= 0)
            {
                altUniverse = false;
                SwitchPlayer();
                universeSwitchTimer = 0;
            }
        }

        TimeRecharge();

    }

    private void TimeRecharge()
    {
        if (universeSwitchTimer < universeSwitchTime)
        {
            energyCharge = true;
        }
        else
        {
            energyCharge = false;
        }

        if (energyCharge = true)
        {
            rechargeTimer -= Time.deltaTime;
        }

        if (rechargeTimer < 0)
        {
            universeSwitchTime += rechargeRate * Time.deltaTime;
            energyCharge = false;
        }    
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("world2"))
        {
            altUniverse = true;
            energyCharge = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("world2"))
        {
            altUniverse = false;
        }
    }
}
