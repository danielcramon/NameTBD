using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemScreen : MonoBehaviour
{
    [SerializeField] InventorySystem inventorySystem;
    [SerializeField] UIManager manager;
    [SerializeField] GameObject item1Display;
    [SerializeField] GameObject item2Display;
    [SerializeField] GameObject item3Display;
    private InventoryObjects object1;
    private InventoryObjects object2;
    private InventoryObjects object3;


    public void DisplayItems(InventoryObjects item1, InventoryObjects item2, InventoryObjects item3)
    {

        CleanDisplay(item1Display);
        CleanDisplay(item2Display);
        CleanDisplay(item3Display);


        object1 = item1;
        object2 = item2;
        object3 = item3;

        EquipmentObject equipment1 = item1.GetComponent<EquipmentObject>();
        EquipmentObject equipment2 = item2.GetComponent<EquipmentObject>();
        EquipmentObject equipment3 = item3.GetComponent<EquipmentObject>();

        //Equipment One

        DisplayItem(item1Display, equipment1);
        DisplayItem(item2Display, equipment2);
        DisplayItem(item3Display, equipment3);


    }

    private void DisplayItem(GameObject itemDisplay, EquipmentObject equipment)
    {
        //Equipment One

        itemDisplay.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = equipment.primary1.ToString();
        itemDisplay.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = equipment.primary1Value.ToString();
        int index = 2;

        if (equipment.primary2 != PrimaryAttribute.None)
        {
            itemDisplay.transform.GetChild(index).GetComponent<TextMeshProUGUI>().text = equipment.primary2.ToString();
            index++;
            itemDisplay.transform.GetChild(index).GetComponent<TextMeshProUGUI>().text = equipment.primary2Value.ToString();
            index++;
        }

        itemDisplay.transform.GetChild(index).GetComponent<TextMeshProUGUI>().text = equipment.secondary1.ToString();
        index++;
        itemDisplay.transform.GetChild(index).GetComponent<TextMeshProUGUI>().text = equipment.secondary1Value.ToString();
        index++;

        if (equipment.secondary2 != SecondaryAttribute.None)
        {
            itemDisplay.transform.GetChild(index).GetComponent<TextMeshProUGUI>().text = equipment.secondary2.ToString();
            index++;
            itemDisplay.transform.GetChild(index).GetComponent<TextMeshProUGUI>().text = equipment.secondary2Value.ToString();
        }

        if (equipment.unique != UniqueEffect.None)
        {
            itemDisplay.transform.GetChild(8).GetComponent<TextMeshProUGUI>().text = equipment.secondary2.ToString();
        }

        itemDisplay.transform.GetChild(9).GetComponent<Image>().sprite = equipment.gameObject.GetComponent<Image>().sprite;
    }

    private void CleanDisplay(GameObject display)
    {
        display.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "";
        display.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "";

        display.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "";
        display.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = "";


        display.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = "";
        display.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = "";


        display.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = "";

        display.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text = "";

        display.transform.GetChild(8).GetComponent<TextMeshProUGUI>().text = "";

        display.transform.GetChild(9).GetComponent<Image>().sprite = null;
    }

    public void PickItem(int index)
    {
        switch (index)
        {
            case 1:
                inventorySystem.AddItem(object1);
                Destroy(object2.gameObject);
                Destroy(object3.gameObject);
                break;
            case 2:
                inventorySystem.AddItem(object2);
                Destroy(object1.gameObject);
                Destroy(object3.gameObject);
                break;
            case 3:
                inventorySystem.AddItem(object3);
                Destroy(object1.gameObject);
                Destroy(object2.gameObject);
                break;
        }

        manager.DeactivateItemPanel();
    }
}
