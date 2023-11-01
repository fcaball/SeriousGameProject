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

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        inventory.gameObject.SetActive(false);
        playerMovement_script = player.GetComponent<PlayerMovement>();
        camera_script = camera.GetComponent<MouseLook>();
    }

    public bool Add(Item item)
    {
        bool ok = true;
        if (item.itemType != Item.ItemType.Empreintes)
        {

            Items.Add(item);
        }
        else
        {
            foreach (Item i in Items)
            {
                if (i.itemType == Item.ItemType.Empreintes)
                {
                    ok = false;
                }
            }
            Debug.Log(ok);
            if (ok) {Items.Add(item); }
        }
        return ok;
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }

    public void CloseInventory()
    {
        inventory.gameObject.SetActive(false);
        playerMovement_script.enabled = true;
        camera_script.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void ListItems()
    {
        GameObject obj = Instantiate(InventoryItem, ItemContent);
        var itemName = obj.transform.Find("ItemName").GetComponent<TMP_Text>();
        var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
        itemName.text = Items[Items.Count - 1].itemName;
        itemIcon.sprite = Items[Items.Count - 1].icon;
        SetInventoryItems();
    }

    public void SetInventoryItems()
    {
        InventoryItems = ItemContent.GetComponentsInChildren<InventoryItemController>();
        Debug.Log("InventoryItems : " + InventoryItems.Length);
        Debug.Log("Items : " + Items.Count);
        InventoryItems[Items.Count - 1].AddItem(Items[Items.Count - 1]);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            inventory.gameObject.SetActive(true);
            playerMovement_script.enabled = false;
            camera_script.enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}