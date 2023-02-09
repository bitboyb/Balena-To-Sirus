using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using STOP_MODE = FMOD.Studio.STOP_MODE;

public class snapshotmaster : MonoBehaviour
{
    public EventReference snapshotevent;

    private EventInstance snapshotinstance;
    // Start is called before the first frame update
    void Start()
    {
        snapshotinstance = RuntimeManager.CreateInstance(snapshotevent);
        snapshotinstance.start();
    }

    public void IsMenu()
    {
        snapshotinstance.setParameterByNameWithLabel("snapshotprammeter", "menu");
    }

    public void IsGame()
    {
        snapshotinstance.setParameterByNameWithLabel("snapshotprammeter","game");
    }

    void Update()
    {
        
    }
}
