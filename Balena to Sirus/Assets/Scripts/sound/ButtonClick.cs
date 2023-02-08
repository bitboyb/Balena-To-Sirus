using System;
using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using UnityEngine;
using FMODUnity;
using UnityEngine.EventSystems;
using STOP_MODE = FMOD.Studio.STOP_MODE;

public class ButtonClick : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public EventReference clicksound;
    public EventReference hoversound;
    private EventInstance hoverinstance;
    
    public void playsound()
    {
        RuntimeManager.PlayOneShot(clicksound);
    }

    public void OnPointerEnter(PointerEventData pData)
    {
        //the mouse enters
        RuntimeManager.PlayOneShot(hoversound);
        //EventInstance hoverinstance = RuntimeManager.CreateInstance(hoversound);
        //hoverinstance.start();
    }

    public void OnPointerExit(PointerEventData pData)
    {
        //mouse exit
        //hoverinstance.stop(STOP_MODE.IMMEDIATE);
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
