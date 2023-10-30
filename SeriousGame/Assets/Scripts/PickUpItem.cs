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
        float distance = Vector3.Distance(cam.transform.position, gameObject.transform.position);
        if (Physics.Raycast(ray, out hit, 10))
        {
            //Debug.Log(hit.transform.tag);
            if (hit.transform.tag == "item" && Input.GetMouseButtonDown(0) && distance < 5f)
            {
                InventoryManager.Instance.Add(item);
                InventoryManager.Instance.ListItems();

                Destroy(gameObject);
            }
        }
    }
}
