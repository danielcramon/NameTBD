using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] LootTable lootTable;

    [SerializeField] int commonChance;
    [SerializeField] int rareChance;
    [SerializeField] int epicChance;

    [SerializeField] ItemScreen itemScreen;
    [SerializeField] PlayerStats stats;
    [SerializeField] GameObject itemParent;

    public void ChooseItems()
    {
        InventoryObjects objectOne = ChooseItem();
        InventoryObjects objectTwo = ChooseItem();
        InventoryObjects objectThree = ChooseItem();

        itemScreen.DisplayItems(objectOne, objectTwo, objectThree);
    }

    public InventoryObjects ChooseItem()
    {
        int baseRandom = Random.Range(1, 1001);
        int random = baseRandom + stats.combinedMagicFind;

        if (random <= commonChance)
        {
            int itemRandom = Random.Range(0, lootTable.commonItems.Count);

            InventoryObjects item = Instantiate(lootTable.commonItems[itemRandom], itemParent.transform);

            item.GetComponent<EquipmentObject>().setValue();

            return item;
        }
        else if(random <= commonChance + rareChance)
        {
            int itemRandom = Random.Range(0, lootTable.rareItems.Count);

            InventoryObjects item = Instantiate(lootTable.rareItems[itemRandom], itemParent.transform);

            item.GetComponent<EquipmentObject>().setValue();

            return item;
        }
        else if (random <= commonChance + rareChance + epicChance)
        {
            int itemRandom = Random.Range(0, lootTable.epicItems.Count);

            InventoryObjects item = Instantiate(lootTable.epicItems[itemRandom], itemParent.transform);

            item.GetComponent<EquipmentObject>().setValue();

            return item;
        }
        else
        {
            int itemRandom = Random.Range(0, lootTable.uniqueItems.Count);

            InventoryObjects item = Instantiate(lootTable.uniqueItems[itemRandom]);

            item.GetComponent<EquipmentObject>().setValue();

            return item;
        }
    }
}
