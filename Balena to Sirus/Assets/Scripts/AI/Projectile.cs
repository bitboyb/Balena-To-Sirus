using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Projectile : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent agent;
    private Vector3 target;
    

    // Start is called before the first frame update
    void Start()
    {
        //target = new Vector3(player.position.x, player.position.y, player.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
    }
}
