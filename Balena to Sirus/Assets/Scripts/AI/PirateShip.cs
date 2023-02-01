using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PirateShip : MonoBehaviour
{
    public float viewDistance = 10f;

    public GameObject firePoint;
    
    
    public Transform target;

    public NavMeshAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if player is in distance, then chance player if still in range.
        if(Vector3.Distance(transform.position, target.position) < viewDistance)
            agent.SetDestination(target.position);

    }
}
