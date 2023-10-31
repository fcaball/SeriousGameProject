using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemController : MonoBehaviour
{
    public Item item;
    bool active_Paper = false;
    bool active_CarlaPhone = false;
    bool active_Wallet = false;

    public void AddItem(Item new_item)
    {
        item = new_item;
    }

    public void RemoveItem()
    {
        InventoryManager.Instance.Remove(item);
        Destroy(gameObject);
    }

    public void UseItem()
    {
        switch (item.itemType)
        {
            case Item.ItemType.Paper:
                active_Paper = !active_Paper;
                GameVariables.canvas_PapierPC.gameObject.SetActive(active_Paper);
                break;

            case Item.ItemType.CarlaPhone:
                active_CarlaPhone = !active_CarlaPhone;
                GameVariables.canvas_CarlaPhone.gameObject.SetActive(active_CarlaPhone);
                break;

            case Item.ItemType.Wallet:
                active_Wallet = !active_Wallet;
                GameVariables.canvas_Wallet.gameObject.SetActive(active_Wallet);
                break;

            default:
                break;
        }
    }


}
