using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Loot Table", menuName = "Inventory System/Loot Table")]
public class LootTable : ScriptableObject
{
    public List<InventoryObjects> commonItems = new List<InventoryObjects>();
    public List<InventoryObjects> rareItems = new List<InventoryObjects>();
    public List<InventoryObjects> epicItems = new List<InventoryObjects>();
    public List<InventoryObjects> uniqueItems = new List<InventoryObjects>();
}
