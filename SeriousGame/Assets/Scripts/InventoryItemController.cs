using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemController : MonoBehaviour
{
    Item item;
    bool active_Paper = false;
    bool active_CarlaPhone = false;

    public void AddItem(Item new_item)
    {
        item = new_item;
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

            default:
                break;
        }
    }


}
