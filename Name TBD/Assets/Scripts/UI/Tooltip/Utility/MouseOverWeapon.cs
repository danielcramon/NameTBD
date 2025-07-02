using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseOverWeapon : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] EquipmentObject equipmentObject;
    public void OnPointerEnter(PointerEventData eventData)
    {
        TooltipWeapon.ShowTooltipStatic(equipmentObject);
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        TooltipWeapon.HideTooltipStatic();
    }

    public void ItemClicked()
    {
        TooltipWeapon.HideTooltipStatic();
    }
}
