using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public Camera cam;
    private RaycastHit hit;

    public Item item;


    private void OnMouseDown()
    {
        /*Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        float distance = Vector3.Distance(cam.transform.position, gameObject.transform.position);
        if (Physics.Raycast(ray, out hit, 10))
        {
            if (hit.transform.tag == "item" && distance < 5f)
            {*/
                InventoryManager.Instance.Add(item);
                InventoryManager.Instance.ListItems();

                Destroy(gameObject);
         /*   }
        }*/
    }
}
