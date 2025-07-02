using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseOverItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] EquipmentObject equipmentObject;
    public void OnPointerEnter(PointerEventData eventData)
    {
        TooltipItem.ShowTooltipStatic(equipmentObject);
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        TooltipItem.HideTooltipStatic();
    }

    public void ItemClicked()
    {
        TooltipItem.HideTooltipStatic();
    }
}
