using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class Fish : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float rotSpeed = 10f;
    public float maxDistance = 30f;

    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;
    public bool wonderdToFar = false;

    public float healing;

    public Transform spawnPoint;
    
    public NavMeshAgent agent;

    private void Start()
    {
        transform.Rotate(0,Random.Range(1,360),0);
    }

    private void Update()
    {
        if (wonderdToFar == false)
        {
            if (isWandering == false)
            {
                StartCoroutine(Wonder());
            }

            if (isRotatingRight == true)
            {
                transform.Rotate(transform.up * (Time.deltaTime * rotSpeed));
            }

            if (isRotatingLeft == true)
            {
                transform.Rotate(transform.up * (Time.deltaTime * -rotSpeed));
            }

            if (isWalking == true)
            {
                transform.position += transform.forward * (moveSpeed * Time.deltaTime);
            }
        }

        /*if (Vector3.Distance(transform.position, spawnPoint.position) > maxDistance)
        {
            gameObject.GetComponent<NavMeshAgent>().isStopped = false;
            wonderdToFar = true;
            agent.SetDestination(spawnPoint.position);
        }

        if (Vector3.Distance(transform.position, spawnPoint.position) < 1)
        {
            gameObject.GetComponent<NavMeshAgent>().isStopped = true;
            wonderdToFar = false;
        }*/
    }

    IEnumerator Wonder()
    {
        int rotTime = Random.Range(1, 3);
        int rotateWait = Random.Range(1, 3);
        int rotateLorR = Random.Range(1, 4);
        int walkWait = Random.Range(1, 4);
        int walkTime = Random.Range(1, 5);

        isWandering = true;

        yield return new WaitForSeconds(walkWait);
        isWalking = true;
        yield return new WaitForSeconds(walkTime);
        isWalking = false;
        yield return new WaitForSeconds(rotateWait);

        if (rotateLorR == 1)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingRight = false;
        }
        
        if (rotateLorR == 2)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingLeft = false;
        }
        isWandering = false;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Health.health += healing;
            Destroy(gameObject);
            FishSpawner.fishCount++;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("FishSwimArea"))
        {
            gameObject.GetComponent<NavMeshAgent>().isStopped = true;
            wonderdToFar = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<NavMeshAgent>().isStopped = false;
        wonderdToFar = true;
        agent.SetDestination(spawnPoint.position);
    }
}
