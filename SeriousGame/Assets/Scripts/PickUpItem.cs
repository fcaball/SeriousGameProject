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

        GameVariables.pickUp_sound = GameObject.Find("pickUpSound").GetComponent<AudioSource>();
    }



    public void Update()
    {
        float distance = Vector3.Distance(cam.transform.position, gameObject.transform.position);

        if (distance < 2.5f)
        {
            near = gameObject;
            canvas_nearest.SetActive(true);
        }
        else if (gameObject == near)
        {
            canvas_nearest.SetActive(false);
            near = null;
        }


    }


    private void OnMouseDown()
    {
        canvas_nearest.SetActive(false);

        if (item.value == 1 && item.itemType == Item.ItemType.Empreintes)
        {
            GameVariables.canvas_cafetiere.SetActive(!GameVariables.canvas_cafetiere.activeSelf);
        }
        else if (item.value == 2 && item.itemType == Item.ItemType.Empreintes)
        {
            GameVariables.canvas_tasse.SetActive(!GameVariables.canvas_tasse.activeSelf);
        }
        else if (item.value == 3 && item.itemType == Item.ItemType.Empreintes)
        {
            GameVariables.canvas_dessin.SetActive(!GameVariables.canvas_dessin.activeSelf);
        }

        bool isAdded = InventoryManager.Instance.Add(item);
        GameVariables.pickUp_sound.Play();

        if (isAdded)
        {
            InventoryManager.Instance.ListItems();
        }

        Destroy(gameObject);

    }


}
