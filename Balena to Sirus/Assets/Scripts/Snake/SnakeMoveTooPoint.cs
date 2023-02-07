using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class SnakeMoveTooPoint : MonoBehaviour
{
    public float waitTimeForNewSpot = 5f;
    public float waitTimeCount;
    

    public GameObject snakeSwimPoint;

    private void Start()
    {
        waitTimeCount = waitTimeForNewSpot;
        
        //Randomizes start swim location
        Vector3 rndPosWithin;
        rndPosWithin = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        rndPosWithin = transform.TransformPoint(rndPosWithin * .5f);
        
        snakeSwimPoint.transform.position = rndPosWithin;
    }

    private void Update()
    {
        //Counting down to move spot to random location
        waitTimeCount -= Time.deltaTime;
        
        //This Resets Counter and triggers method to move swim spot to a random location
        if (waitTimeCount < 0)
        {
            //Resets Counter
            waitTimeCount = waitTimeForNewSpot;
            
            //Start Method Randomise location
            moveSwimSpot();
        }
    }

    private void moveSwimSpot()
    {
        //Randomizes new swim location
        Vector3 rndPosWithin;
        rndPosWithin = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        rndPosWithin = transform.TransformPoint(rndPosWithin * .5f);
        
        snakeSwimPoint.transform.position = rndPosWithin;
    }
}
