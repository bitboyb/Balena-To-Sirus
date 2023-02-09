using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using UnityEngine;
using FMODUnity;

public class playerdamage : MonoBehaviour
{
    public EventReference whalehit;

    private EventInstance poke;

    private float scale = 10f;
    // Start is called before the first frame update
    void Start()
    {
        poke = RuntimeManager.CreateInstance(whalehit);
        poke.start();
    }

    void Isfullhealth()
    {
        poke.setParameterByName("Parameter 2", 10);
    }
    
    void Ishalfhealth()
    {
        poke.setParameterByName("Parameter 2", 5);
    }
    void Islowerhealth()
    {
        poke.setParameterByName("Parameter 2", 3);
    }
    void Update()
    {
        
    }
}
