using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

public class snapshotcontroler : MonoBehaviour
{
    public EventReference snapshotevent;

    private EventInstance snapshotinstance;
    // Start is called before the first frame update
    void Start()
    {
        snapshotinstance = RuntimeManager.CreateInstance(snapshotevent);
    }

    public void IsMenu()
    {
        snapshotinstance.setParameterByName("snapshotprammeter", 0);
    }
    
    public void IsGame()
    {
        snapshotinstance.setParameterByName("snapshotprammeter", 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
