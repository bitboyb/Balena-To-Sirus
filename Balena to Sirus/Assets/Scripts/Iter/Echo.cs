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
    
    //Echo distance saved here
    public float echoDistance1;
    public float echoDistance2;
    public float echoDistance3;
    public float endPortalDistance;
    
    //Calculations
    public float scaleMultiplier;
    public float echoDelay;
    public float delayCount;
  
    //Calls to responed echos
    private bool recallEcho;
    
    public GameObject echo;
    public GameObject echo2;
    public GameObject echo3;

    public GameObject endPortal;
    
    
    public ParticleSystem echoP1;
    public ParticleSystem echoP2;
    public ParticleSystem echoP3;

    public ParticleSystem endPortalP;
    
    public ParticleSystem iterEcho;
    
    public Transform player;
    
    public Transform echoT1;
    public Transform echoT2;
    public Transform echoT3;

    public Transform endPortalT;
    
    public Camera camera1;

    private Vector3 initialScale;


    // Update is called once per frame
    private void Start()
    {
        initialScale = echo.transform.localScale;
        delayCount = echoDelay;
        //Makes sure the game does not echo when first load in
        iterEcho.Stop();
        echoP1.Stop();
        echoP2.Stop();
        endPortalP.Stop();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EchoOut();
            //plays sound 
            RuntimeManager.PlayOneShot(echosound);
        }
           
        

        if (recallEcho)
            delayCount -= Time.deltaTime;
        
        //This where the echo recall happens.
        if (delayCount <= 0)
        {
            recallEcho = false;
            delayCount = echoDelay;
            //Add partical system in here
            echoP1.Play();
            echoP2.Play();
            echoP3.Play();
            
            if (Portal.allCrystalsCollected)
            {
                endPortalP.Play();
            }
        }

        //Calculate echo size
        echoDistance1 = Vector3.Distance(echoT1.position, player.position);
        
        echo.transform.localScale = initialScale + Vector3.one * (echoDistance1 * scaleMultiplier);
        
        echoDistance2 = Vector3.Distance(echoT2.position, player.position);
        
        echo2.transform.localScale = initialScale + Vector3.one * (echoDistance2 * scaleMultiplier);
        
        echoDistance3 = Vector3.Distance(echoT3.position, player.position);
        
        echo3.transform.localScale = initialScale + Vector3.one * (echoDistance3 * scaleMultiplier);
        
        endPortalDistance = Vector3.Distance(echoT3.position, player.position);
        //Changes echo size
        //echo.transform.localScale = initialScale + Vector3.one * (echoDistance1 * scaleMultiplier);
        //echo2.transform.localScale = initialScale + Vector3.one * (echoDistance2 * scaleMultiplier);
        //echo3.transform.localScale = initialScale + Vector3.one * (echoDistance3 * scaleMultiplier);
        endPortal.transform.localScale = initialScale + Vector3.one * (endPortalDistance * scaleMultiplier);

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
