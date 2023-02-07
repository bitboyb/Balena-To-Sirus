using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SnakeHead : MonoBehaviour
{
    //View Distance of player range
    public float viewDistance = 10f;
    //Checking if chasing the player
    private bool chasingPlayer;
    
    //For chasing the player
    public Transform player;
    
    //Swim point location
    public Transform swimPoint;
    
    public NavMeshAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {
        chasingPlayer = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if player is in distance, then chase player if still in range.
        if (Vector3.Distance(transform.position, player.position) < viewDistance && Hide.isHiding == false)
        {
            chasingPlayer = true;
            ChasePlayer();
        }
        else
        {
            chasingPlayer = false;
        }
        
        //Checks if chasing player, if not roam
        if(chasingPlayer == false)
            Roam();
    }

    private void Roam()
    {
        agent.SetDestination(swimPoint.position);
    }

    void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Health.health = 0;
    }
}