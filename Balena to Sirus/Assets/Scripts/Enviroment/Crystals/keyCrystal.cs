using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class keyCrystal : MonoBehaviour
{
    private bool followIter = false;
    
    public Transform iter;
    

    public NavMeshAgent agent;

    private void Update()
    {
        if (followIter == true)
        {
            FollowIter();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            followIter = true;
            Portal.collectedCrystals++;
        }
    }

    private void FollowIter()
    {
        agent.SetDestination(iter.position);
    }
}
