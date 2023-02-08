using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotPlanetRound : MonoBehaviour
{

    public float rotSpeed;

    private bool pushedOfCourse;

    public GameObject pivotObject;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pushedOfCourse == false)
        {
            transform.RotateAround(pivotObject.transform.position, new Vector3(0, 1, 0), rotSpeed * Time.deltaTime);
        }

        if (pushedOfCourse)
        {
            transform.RotateAround(pivotObject.transform.position, new Vector3(0, 0, 0), 0 * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pushedOfCourse = true;
        }
    }
}
