using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class rockCluster : MonoBehaviour
{
    public int rocks;
    private int rocksCount;
    

    public GameObject Rocks;

    private void Start()
    {
        rocksCount = rocks;
    }

    // Update is called once per frame
    void Update () 
    {           
       
        if(rocksCount > 0)
        {
            rocksCount--;
            // Random position within this transform
            Vector3 rndPosWithin;
            rndPosWithin = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            rndPosWithin = transform.TransformPoint(rndPosWithin * .5f);
            Instantiate(Rocks, rndPosWithin, transform.rotation);      
        }
    }
}