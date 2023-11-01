using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    GameObject cam;
    private RaycastHit hit;
    GameObject canvas_nearest;

    public static GameObject near;

    public Item item;

    private void Awake()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        canvas_nearest = GameObject.FindGameObjectWithTag("nearest");
    }

    private void Start()
    {
        canvas_nearest.SetActive(false);
        //near = false;
    }



    public void Update()
    {
        float distance = Vector3.Distance(cam.transform.position, gameObject.transform.position);

        if(distance < 2.5f)
        {
            near = gameObject;
            canvas_nearest.SetActive(true);
        }
        else if(gameObject == near)
        {
            canvas_nearest.SetActive(false);
            near = null;
        }

        
    }


    private void OnMouseDown()
    {
        canvas_nearest.SetActive(false);

        InventoryManager.Instance.Add(item);

        InventoryManager.Instance.ListItems();

        Destroy(gameObject);
       
    }

    
}
