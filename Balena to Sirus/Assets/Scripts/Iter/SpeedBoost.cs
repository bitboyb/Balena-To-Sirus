using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{



    public PlayerController pController;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*if (_isBoosting == true) 
            _speedBoostCount -= 1 * Time.deltaTime;

        if(_speedBoostCount == 0)
        {
            _speedBoostCount = speedBoostTimer;
            _isBoosting = false;
            PlayerController.currentSpeed -= speedBoost;
        }*/
    }
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            PlayerController.IsBoosted = true;
        }
    }
}
