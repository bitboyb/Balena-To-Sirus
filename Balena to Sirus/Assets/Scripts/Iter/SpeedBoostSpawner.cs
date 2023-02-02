using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostSpawner : MonoBehaviour
{
    public static bool boosterDestroyed;

    public float respawnTimer;
    private float respawnTimerCount;

    public GameObject booster;

    // Start is called before the first frame update
    void Start()
    {
        boosterDestroyed = false;
        respawnTimerCount = respawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (boosterDestroyed == true)
        {
            RespawnBooster();
        }
    }

    private void RespawnBooster()
    {
        if (respawnTimerCount <= 0f)
        {
            boosterDestroyed = false;
            Instantiate(booster, transform.position, Quaternion.identity);
            respawnTimerCount = respawnTimer;
        }
        else
        {
            respawnTimerCount -= Time.deltaTime;
        }
    }
}
