using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<string> itemList;

    public void AddItem(string itemName)
    {
        itemList.Add(itemName);
    }

    public bool HasItem(string itemName)
    {
        return itemList.Contains(itemName);
    }
}
