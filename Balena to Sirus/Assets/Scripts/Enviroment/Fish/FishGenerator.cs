using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FishGenerator : MonoBehaviour
{
    public int howManyFish;
    private int fishCount;

    public GameObject fishSpawner;
    
    // Start is called before the first frame update
    void Start()
    {
        fishCount = howManyFish;
    }

    // Update is called once per frame
    void Update()
    {
        if(fishCount > 0)
        {
            fishCount--;
            // Random position within this transform
            Vector3 rndPosWithin;
            rndPosWithin = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            rndPosWithin = transform.TransformPoint(rndPosWithin * .5f);
            Instantiate(fishSpawner, rndPosWithin, transform.rotation);      
        }
    }
}
