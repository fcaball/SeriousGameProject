using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public Camera cam;
    private RaycastHit hit;

    public Item item;


    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 20))
        {
            if (hit.transform.tag == "item" && Input.GetMouseButtonDown(0))
            {
                InventoryManager.Instance.Add(item);
                InventoryManager.Instance.ListItems();

                Destroy(gameObject);
            }
        }
    }
}
