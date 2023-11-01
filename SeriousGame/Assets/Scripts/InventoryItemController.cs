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
                GameVariables.canvas_charade.gameObject.SetActive(active_CarlaPhone);
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

            case Item.ItemType.BenoitPhone:
                GameVariables.canvas_BenoitPhone.SetActive(!GameVariables.canvas_BenoitPhone.activeSelf);
                break;

            case Item.ItemType.Empreintes:
                GameVariables.canvas_empreinte.SetActive(!GameVariables.canvas_empreinte.activeSelf);
                break;
            /*  case Item.ItemType.Painting:
                  GameVariables.canvas_empreinte.SetActive(!GameVariables.canvas_empreinte.activeSelf);
                  GameVariables.canvas_dessin.SetActive(!GameVariables.canvas_dessin.activeSelf);
                  break;

              case Item.ItemType.Cafetiere:
                  GameVariables.canvas_empreinte.SetActive(!GameVariables.canvas_empreinte.activeSelf);
                  GameVariables.canvas_cafetiere.SetActive(!GameVariables.canvas_cafetiere.activeSelf);

                  break;

              case Item.ItemType.Tasse:
                  GameVariables.canvas_empreinte.SetActive(!GameVariables.canvas_empreinte.activeSelf);
                  GameVariables.canvas_tasse.SetActive(!GameVariables.canvas_tasse.activeSelf);
                  break;*/

            default:
                break;
        }
    }


}
