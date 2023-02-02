using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateFire : MonoBehaviour
{
    public float fireRange = 7f;
    private float shotTimer;
    public float startShotTimer;

    public GameObject projectile;

    public Transform aim;
    public Transform firePoint;
    
    // Start is called before the first frame update
    void Start()
    {
        shotTimer = startShotTimer;
    }

    // Update is called once per frame
    void Update()
    {
        
        //Checks if shooting range.
        if (Vector3.Distance(transform.position, aim.position) < fireRange && Hide.isHiding == false)
        {
            FireCannon();
        }
    }

    private void FireCannon()
    {
        if (shotTimer <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            shotTimer = startShotTimer;
        }
        else
        {
            shotTimer -= Time.deltaTime;
        }
    }
}
