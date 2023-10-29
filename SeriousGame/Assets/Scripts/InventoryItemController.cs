using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemController : MonoBehaviour
{
    Item item;
    bool active = false;

    public void AddItem(Item new_item)
    {
        item = new_item;
    }

    public void UseItem()
    {
        active = !active;
        switch(item.itemType)
        {
            case Item.ItemType.Paper:
                GameVariables.canvas[0].gameObject.SetActive(active);
                break;

            case Item.ItemType.Phone:
                GameVariables.canvas[1].gameObject.SetActive(active);
                break;

            default:
                break;
        }
    }


}
