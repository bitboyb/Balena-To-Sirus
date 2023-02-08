using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using FMODUnity;

public class Echo : MonoBehaviour
{
    //calls sound 
    public EventReference echosound;
    public float echoDistance1;
    public float echoDistance2;
    public float scaleMultiplier;
    public float echoDelay;
    private float delayCount;
  

    private bool recallEcho;
    
    public GameObject echo;
    public GameObject echo2;
    
    
    public ParticleSystem echoP;
    public ParticleSystem echoCrystal1;
    
    public ParticleSystem iterEcho;
    
    public Transform player;
    public Transform echo1;
    public Transform echoC1;
    
    public Camera camera1;

    private Vector3 initialScale;


    // Update is called once per frame
    private void Start()
    {
        initialScale = echo.transform.localScale;
        delayCount = echoDelay;
        //Makes sure the game does not echo when first load in
        iterEcho.Stop();
        echoP.Stop();
        echoCrystal1.Stop();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EchoOut();
            //plays sound 
            RuntimeManager.PlayOneShot(echosound);
        }
           
        

        if (recallEcho == true)
            delayCount -= Time.deltaTime;
        
        //This where the echo recall happens.
        if (delayCount <= 0)
        {
            recallEcho = false;
            //Add partical system in here in here
            echoP.Play();
            echoCrystal1.Play();
            delayCount = echoDelay;
        }

        //Calculate echo size
        echoDistance1 = Vector3.Distance(echo1.position, player.position);
        echoDistance2 = Vector3.Distance(echoC1.position, player.position);
        
        //Changes echo size
        echo.transform.localScale = initialScale + Vector3.one * (echoDistance1 * scaleMultiplier);
        echo2.transform.localScale = initialScale + Vector3.one * (echoDistance2 * scaleMultiplier);

        //echo.transform.position = Camera.main.WorldToScreenPoint(echo1.position);

        //Vector3 pos = camera1.WorldToScreenPoint(echo1.position);

        //pos.x = Mathf.Clamp(pos.x, 0, Screen.width);
        //pos.y = Mathf.Clamp(pos.x, 0, Screen.height);

        //echo.transform.position = pos;
    }

    private void EchoOut()
    {
        iterEcho.Play(); 
        recallEcho = true;
    }
}
