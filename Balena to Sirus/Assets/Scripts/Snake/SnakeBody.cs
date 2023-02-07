using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SnakeBody : MonoBehaviour
{
    public float segDistance;
    private float normaleSpeed;
    
    public Transform nextBody;

    public NavMeshAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {
        normaleSpeed = agent.speed;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(nextBody.position);
        
        if (Vector3.Distance(transform.position, nextBody.position) < segDistance)
        {
            agent.speed = 10;
        }
        else
        {
            agent.speed = normaleSpeed;
        }
    }
}
