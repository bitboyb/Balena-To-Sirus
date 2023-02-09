using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public static float collectedCrystals;
    public float levelCrystalCount;

    public static bool allCrystalsCollected = false;
    
    public GameObject portalGate;
    public ParticleSystem endPortal;
    
    // Start is called before the first frame update
    void Start()
    {
        portalGate.SetActive(false);
        endPortal.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (collectedCrystals == levelCrystalCount)
        {
            portalGate.SetActive(true);
            endPortal.Play();
            allCrystalsCollected = true;
        }
    }
}
