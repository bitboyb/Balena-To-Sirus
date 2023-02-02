using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawner : MonoBehaviour
{
    public static bool healingDestroyed;

    public float respawnTimer;
    private float respawnTimerCount;

    public GameObject healing;

    // Start is called before the first frame update
    void Start()
    {
        healingDestroyed = false;
        respawnTimerCount = respawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (healingDestroyed == true)
        {
            RespawnHealth();
        }
    }

    private void RespawnHealth()
    {
        if (respawnTimerCount <= 0f)
        {
            healingDestroyed = false;
            Instantiate(healing, transform.position, Quaternion.identity);
            respawnTimerCount = respawnTimer;
        }
        else
        {
            respawnTimerCount -= Time.deltaTime;
        }
    }
}
