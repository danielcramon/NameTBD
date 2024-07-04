using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] List<InventoryObjects> inventoryItems = new List<InventoryObjects>();
    [SerializeField] EquipmentSystem equipmentSystem;

    private void Update()
    {
        for (int i = 0; i < inventoryItems.Count; i++)
        {
            if (inventoryItems[i] != null && transform.GetChild(i).childCount == 0)
            {
                Instantiate(inventoryItems[i], transform.GetChild(i));
            }
            if (inventoryItems[i] == null && transform.GetChild(i).childCount != 0)
            {
                Destroy(transform.GetChild(i).GetChild(0).gameObject);
            }
        }
    }

    public void AddItem(InventoryObjects inventoryObject)
    {
        for (int i = 0; i < inventoryItems.Count; i++)
        {
            if(inventoryItems[i] == null)
            {
                inventoryItems[i] = inventoryObject;
                break;
            }
        }
    }

    public void UseInventoryItem(int index)
    {
        if(inventoryItems[index] != null)
        {
            if (inventoryItems[index].Activate())
            {
                InventoryObjects temp = inventoryItems[index];
                inventoryItems[index] = null;
                equipmentSystem.AddEquipment(temp);
            }
            else
            {
                inventoryItems.RemoveAt(index);
            }

        }
    }

}
