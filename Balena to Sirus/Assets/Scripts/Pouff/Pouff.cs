using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pouff : MonoBehaviour
{
    public static bool toHint;

    public float hintDistance;

    public NavMeshAgent agent;

    public Transform iter;

    public Transform hint1;
    
    private void Start()
    {
        toHint = false;
    }

    private void FixedUpdate()
    {
        if (toHint = false)
            agent.SetDestination(iter.position);

        if (toHint = true)
            MoveToHint();
    }

    private void MoveToHint()
    {
        if (Vector3.Distance(transform.position, hint1.position) < hintDistance)
        {
            agent.SetDestination(hint1.position);
        }
    }

    private void FollowIter()
    {

    }
}
