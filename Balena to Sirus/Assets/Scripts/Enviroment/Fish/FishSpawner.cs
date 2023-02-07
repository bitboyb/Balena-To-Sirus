using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public int maxFish = 30;
    public static int fishCount;

    public GameObject fish;

    private void Start()
    {
        fishCount = maxFish;
    }

    private void Update()
    {
        if (fishCount > 0)
        {
            fishCount--;
            // Random position within this transform
            Vector3 rndPosWithin;
            rndPosWithin = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            rndPosWithin = transform.TransformPoint(rndPosWithin * .5f);
            Instantiate(fish, rndPosWithin, transform.rotation);
        }
    }
}
