using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpItem : MonoBehaviour
{
    GameObject cam;
    private RaycastHit hit;
    GameObject canvas_nearest;

    public static GameObject near;

    GameObject add_text;

    public Item item;

    private IEnumerator coroutine;
    private static bool isAdded;

    private bool taken;

    private void Awake()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        canvas_nearest = GameObject.FindGameObjectWithTag("nearest");
        add_text = GameObject.FindGameObjectWithTag("add_text");
        taken = false;
    }

    private void Start()
    {
        canvas_nearest.SetActive(false);
        add_text.SetActive(false);
        isAdded = false;
    }



    public void Update()
    {
        float distance = Vector3.Distance(cam.transform.position, gameObject.transform.position);

        if (distance < 2.5f && !taken)
        {
            near = gameObject;
            canvas_nearest.SetActive(true);
        }
        else if (gameObject == near)
        {
            canvas_nearest.SetActive(false);
            near = null;
        }

        //if(isAdded)
        //{
            //StartCoroutine(WaitAndDisable(2));
            //isAdded = false;
        //}
    }


    private IEnumerator OnMouseDown()
    {
        canvas_nearest.SetActive(false);
        Debug.Log(canvas_nearest.activeSelf);
        taken = true;

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

        isAdded = InventoryManager.Instance.Add(item);
        GameVariables.pickUp_sound.Play();
        add_text.SetActive(true);

        Debug.Log(isAdded);

        if (isAdded)
        {
            InventoryManager.Instance.ListItems();
        }

        yield return new WaitForSeconds(1.0f);

        add_text.SetActive(false);
        
        Destroy(gameObject);

    }

    /*IEnumerator WaitAndDisable(float waitTime)
    {
        Debug.Log("despacito");
        
    }*/


}
