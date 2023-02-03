using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class Echo : MonoBehaviour
{
    public float echoDistance;
    public float scaleMultiplier;
    public float echoDelay;
    private float delayCount;
  

    private bool recallEcho;
    
    public GameObject echo;
    
    
    public ParticleSystem echoP;
    public ParticleSystem iterEcho;
    
    public Transform player;
    public Transform echo1;
    
    public Camera camera1;

    private Vector3 initialScale;


    // Update is called once per frame
    private void Start()
    {
        initialScale = echo.transform.localScale;
        delayCount = echoDelay;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            EchoOut();
        
        if (recallEcho == true)
            delayCount -= Time.deltaTime;
        
        if (delayCount <= 0)
        {
            recallEcho = false;
            echoP.Play();
            delayCount = echoDelay;
        }

        
        echoDistance = Vector3.Distance(echo1.position, player.position);
        echo.transform.localScale = initialScale + Vector3.one * (echoDistance * scaleMultiplier);
        
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
