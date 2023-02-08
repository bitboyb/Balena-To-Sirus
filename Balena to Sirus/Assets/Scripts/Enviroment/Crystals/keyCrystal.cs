using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class keyCrystal : MonoBehaviour
{
    public Transform player;

    public NavMeshAgent agent;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            agent.SetDestination(player.position);
            keyCrystalMem.collectedCrystals++;
            
        }
    }
}
