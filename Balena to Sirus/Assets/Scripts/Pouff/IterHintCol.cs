using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IterHintCol : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hint"))
            PoufControler.isHint = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hint"))
            PoufControler.isHint = false;
    }
}
