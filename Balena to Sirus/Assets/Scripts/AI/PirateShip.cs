using System;
using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;
using UnityEngine.AI;

public class PirateShip : MonoBehaviour
{
    //View Distance of player range
    public float viewDistance = 10f;
    //Checking what point it needs to go to next
    public float checkPointCounter;
    //Checking if chasing the player
    private bool chasingPlayer;
    public float waitBeforMoving = 2f;
    public float delayCounter;
    public EventReference soundmoving;

    //For chasing the player
    public Transform player;
    //Check point locations
    public Transform checkPoint1;
    public Transform checkPoint2;
    public Transform checkPoint3;


    public NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        chasingPlayer = false;
        checkPointCounter = 1;
        delayCounter = waitBeforMoving;
    }

    // Update is called once per frame
    void Update()
    {
        //Checking if player is being chased, if not it will run through the check point system
        if (chasingPlayer == false)
            delayCounter -= Time.deltaTime;


        if (delayCounter < 0)
        {
            CheckPointSystem();
            delayCounter = waitBeforMoving;
        }



        //Checks if player is in distance, then chase player if still in range.
        if (Vector3.Distance(transform.position, player.position) < viewDistance && Hide.isHiding == false)
        {
            chasingPlayer = true;
            ChasePlayer();
        }
        else
        {
            chasingPlayer = false;
            agent.stoppingDistance = 0;
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
        agent.stoppingDistance = 5;
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
