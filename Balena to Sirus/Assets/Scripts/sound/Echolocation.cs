using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using UnityEngine;
using FMODUnity;


public class Echolocation : MonoBehaviour
{

    public EventReference Ambe;
    

    public List<GameObject> EcholoacGameObjects;
    // Start is called before the first frame update
    void Start()
    {
        RuntimeManager.CreateInstance(Ambe);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
