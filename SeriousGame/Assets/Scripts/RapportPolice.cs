using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapportPolice : MonoBehaviour
{
    public Item rapport;
    void Start()
    {
        bool isAdded = InventoryManager.Instance.Add(rapport);

        if (isAdded)
        {
            InventoryManager.Instance.ListItems();
        }
    }
}
