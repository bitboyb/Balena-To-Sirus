using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemChecker : MonoBehaviour
{
    public string itemName;
    private Inventory playerInventory;

    private void Start()
    {
        playerInventory = GameObject.Find("Player").GetComponent<Inventory>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (playerInventory.HasItem(itemName))
        {
            //do stuff here
        }
        else
        {
            //what happens if player does not have item
        }
    }
}
