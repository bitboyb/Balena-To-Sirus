using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public string itemName;
    private Inventory playerInventory;

    private void Start()
    {
        playerInventory = GameObject.Find("Player").GetComponent<Inventory>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        playerInventory.AddItem(itemName);
        Destroy(gameObject);
    }
}
