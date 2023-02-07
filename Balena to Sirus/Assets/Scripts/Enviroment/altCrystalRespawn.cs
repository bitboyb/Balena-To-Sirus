using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altCrystalRespawn : MonoBehaviour
{
    public bool altCrystalDestoryed;

    public float respawnTimer;
    private float respawnTimerCount;

    public GameObject altCrystal;

    // Start is called before the first frame update
    void Start()
    {
        altCrystalDestoryed = false;
        respawnTimerCount = respawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (altCrystalDestoryed == true)
        {
            RespawnAltCrystal();
        }
    }

    private void RespawnAltCrystal()
    {
        if (respawnTimerCount <= 0f)
        {
            altCrystalDestoryed = false;
            Instantiate(altCrystal, transform.position, Quaternion.identity);
            respawnTimerCount = respawnTimer;
        }
        else
        {
            respawnTimerCount -= Time.deltaTime;
        }
    }
}
