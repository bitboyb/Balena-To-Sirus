using System;
using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;
using UnityEngine.UI;

public class playerwarp : MonoBehaviour
{
    public float universeSwitchTime = 10f;
    public float universeSwitchTimer;

    public static bool altUniverse;
    public EventReference warpsound;
    
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
    }

    // Update is called once per frame
    void Update()
    {
        //altUniText.text = "Time Left:" + universeSwitchTimer.ToString();
        //timeShiftSlider.value = universeSwitchTimer;
        
        if (Input.GetKeyDown("e") && universeSwitchTimer > 0)
        {
            RuntimeManager.PlayOneShot(warpsound);
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
        
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("world2"))
        {
            altUniverse = true;
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
