using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PirateShip : MonoBehaviour
{
    //View Distance of player range
    public float viewDistance = 10f;
    public float checkPointCounter;

    private bool chasingPlayer;

    //For chasing the player
    public Transform player;

    public Transform checkPoint1;
    public Transform checkPoint2;
    public Transform checkPoint3;


    public NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        chasingPlayer = false;
        checkPointCounter = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (chasingPlayer == false)
            CheckPointSystem();


        //Checks if player is in distance, then chance player if still in range.
        if (Vector3.Distance(transform.position, player.position) < viewDistance)
        {
            chasingPlayer = true;
            ChasePlayer();
        }
        else
        {
            chasingPlayer = false;
        }
    }

    private void CheckPointSystem()
    {
        if (checkPointCounter == 1)
        {
            agent.SetDestination(checkPoint1.position);

        }

        if (checkPointCounter == 2)
        {
            agent.SetDestination(checkPoint2.position);

        }

        if (checkPointCounter == 3)
        {
            agent.SetDestination(checkPoint3.position);

        }
    }

    void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CheckPoint1"))
        {
            checkPointCounter++;
        }

        if (other.CompareTag("CheckPoint2"))
        {
            checkPointCounter++;
        }

        if (other.CompareTag("CheckPoint3"))
        {
            checkPointCounter = 1;
        }
    }
}
