
using UnityEngine;

[CreateAssetMenu(fileName ="New Item", menuName ="Item/Create New Item")]
public class Item : ScriptableObject
{

    public int id;
    public string itemName;
    public int value;
    public Sprite icon;

    public ItemType itemType;

    public enum ItemType
    {
        Paper,
        CarlaPhone,
        BenoitPhone,
        Wallet,
        Notice,
        Ordonnance,
        Pilulier,
        Medicaments,
        Photo,
        Empreintes,
        Rapport
    }
 
}
