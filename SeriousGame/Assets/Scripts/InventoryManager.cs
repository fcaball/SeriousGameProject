using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using SojaExiles;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new();

    public Transform ItemContent;
    public GameObject InventoryItem;

    public InventoryItemController[] InventoryItems;

    public Canvas inventory;
    PlayerMovement playerMovement_script;
    MouseLook camera_script;
    public GameObject player;
    public GameObject camera;

    public GridLayoutGroup grid;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        inventory.gameObject.SetActive(false);
        playerMovement_script = player.GetComponent<PlayerMovement>();
        camera_script = camera.GetComponent<MouseLook>();
        GameVariables.CarlaEnigmaSolved = false;
    }

    public void Add(Item item)
    {
        Items.Add(item);
        SetInventoryItems();
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }

    public void ClearDuplicate()
    {
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }
    }

    public void CloseInventory()
    {
        //ClearDuplicate();
        inventory.gameObject.SetActive(false);
        playerMovement_script.enabled = true;
        camera_script.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ListItems()
    {
        //ClearDuplicate();
        foreach (var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<TMP_Text>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
        }

        //SetInventoryItems();
    }

    public void SetInventoryItems()
    {
        //InventoryItems = ItemContent.GetComponentsInChildren<InventoryItemController>();
        
       /* Debug.Log("InventoryItems : " + InventoryItems.Length);
        Debug.Log("ItemContent : " + ItemContent.childCount);
        Debug.Log("Items : " + Items.Count);*/

        for (int i = 0; i < Items.Count; i++)
        {
            //InventoryItems[i].AddItem(Items[i]);
            ItemContent.GetChild(i).GetChild(1).GetComponent<Image>().sprite = Items[i].icon;
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            //ClearDuplicate();
            //ListItems();
            inventory.gameObject.SetActive(true);
            playerMovement_script.enabled = false;
            camera_script.enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
