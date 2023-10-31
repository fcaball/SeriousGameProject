using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemController : MonoBehaviour
{
    public Item item;
    bool active_Paper = false;
    bool active_CarlaPhone = false;
    bool active_Wallet = false;
    bool active_Notice = false;
    bool active_Ordonnance = false;
    bool active_Pilulier = false;
    bool active_Medicaments = false;

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

            case Item.ItemType.Notice:
                active_Notice = !active_Notice;
                GameVariables.canvas_Notice.gameObject.SetActive(active_Notice);
                break;

            case Item.ItemType.Ordonnance:
                active_Ordonnance = !active_Ordonnance;
                GameVariables.canvas_Ordonnance.gameObject.SetActive(active_Ordonnance);
                break;

            case Item.ItemType.Pilulier:
                active_Pilulier = !active_Pilulier;
                GameVariables.canvas_Pilulier.gameObject.SetActive(active_Pilulier);
                break;

            case Item.ItemType.Medicaments:
                active_Medicaments = !active_Medicaments;
                GameVariables.canvas_Medicaments.gameObject.SetActive(active_Medicaments);
                break;

            case Item.ItemType.Photo:
                GameVariables.canvas_Photo.SetActive(!GameVariables.canvas_Photo.activeSelf);
                break;

            default:
                break;
        }
    }


}
