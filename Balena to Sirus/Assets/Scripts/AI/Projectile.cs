using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float decayTime;
    public float damage = 10f;

    public Transform player;
    private Vector3 target;

    public Health playersHealth;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector3(player.position.x, player.position.y, player.position.z);
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        if (transform.position.x == target.x && transform.position.y == target.y && transform.position.z == target.z)
        {
            DestroyProjectile();
        }
        
        Destroy(gameObject, decayTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DestroyProjectile();
            Health.health -= damage;
        }
    }

    private void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
