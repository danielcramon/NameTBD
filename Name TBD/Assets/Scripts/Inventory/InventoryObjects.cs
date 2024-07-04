using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Type
{
    Equipment,
    Consumable
}
public enum EquipmentType
{
    Necklace,
    Chest,
    Ring,
    Weapon,
    Belt,
    Pants,
    Boots,
    None,
}
public abstract class InventoryObjects : MonoBehaviour
{
    public Type type;
    public EquipmentType equipmentType;
    [TextArea(15, 20)]
    public string description;

    public virtual bool Activate()
    {
        return false;
    }
}
