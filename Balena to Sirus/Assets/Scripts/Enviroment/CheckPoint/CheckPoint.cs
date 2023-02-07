using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public bool activated = false;

    public static GameObject[] checkPointList;

    private void Start()
    {
        checkPointList = GameObject.FindGameObjectsWithTag("PCheckPoint");
    }

    private void ActivateCheckPoint()
    {
        foreach (GameObject cp in checkPointList)
        {
            cp.GetComponent<CheckPoint>().activated = false;
            //cp.GetComponent<>().setBool("Active", false);
        }

        activated = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ActivateCheckPoint();
        }
    }

    // ReSharper disable Unity.PerformanceAnalysis
    public static Vector3 GetActiveCheckPointPoisition()
    {
        Vector3 result = new Vector3(0, 0, 0);
        if (checkPointList != null)
        {
            foreach (GameObject cp in checkPointList)
            {
                // We search the activated checkpoint to get its position
                if (cp.GetComponent<CheckPoint>().activated)
                {
                    result = cp.transform.position;
                    break;
                }
            }
        }

        return result;
    }
    
}

