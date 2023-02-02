using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    [SerializeField] private Material hideingM;

    private float halfSpeed;
    public static bool isHiding;
    
    // Start is called before the first frame update
    void Start()
    {
        isHiding = false;

        Color color = hideingM.color;
        color.a = 1;
        hideingM.color = color;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hide"))
        {
            IsHiding();
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hide"))
        {
            NotHiding();
        }
    }
    
    private void IsHiding()
    {
        isHiding = true;
        Color color = hideingM.color;
        color.a = 0;
        hideingM.color = color;
    }

    private void NotHiding()
    {
        isHiding = false;
        Color color = hideingM.color;
        color.a = 1;
        hideingM.color = color;
    }
}
