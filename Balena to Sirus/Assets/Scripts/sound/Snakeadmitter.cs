using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using UnityEngine;
using FMODUnity;

public class Snakeadmitter : MonoBehaviour


{
    public EventReference snake;

    private EventInstance SnakeInstance;
    // Start is called before the first frame update
    void Start()
    {
        SnakeInstance = RuntimeManager.CreateInstance(snake);
        SnakeInstance.start();
    }

    public void IsPatrolin()
    {
        SnakeInstance.setParameterByName("Parameter 1", 0);
    }
    public void IsChasing()
    {
        SnakeInstance.setParameterByName("Parameter 1", 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
