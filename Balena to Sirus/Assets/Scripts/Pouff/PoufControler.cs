using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PoufControler : MonoBehaviour
{
    //This to check for closest hint point
    public float hintDistance;

    
    private bool isFollowingIter;
    public static bool isHint;
    
    public NavMeshAgent agent;
    
    public Transform iter;
    
    //Hint List
    public Transform hint1;
    public Transform hint2;
    
    private float closeHintSpot;


    private void Start()
    {
        isHint = false;
    }

    private void Update()
    {
        FollowIter();

        if (isHint == true)
        {
            MovingToHint();
        }
    }
    

    private void FollowIter()
    {
        if (isHint == false)
        {
            agent.SetDestination(iter.position);
        }
    }

    private void MovingToHint()
    {
        if (Vector3.Distance(transform.position, hint1.position) < hintDistance)
        {
            agent.SetDestination(hint1.position);
        }
        
        if (Vector3.Distance(transform.position, hint2.position) < hintDistance)
        {
            agent.SetDestination(hint2.position);
        }
    }
}
