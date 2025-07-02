using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] string tooltipString;
    public void OnPointerEnter(PointerEventData eventData)
    {
        Tooltip.ShowTooltipStatic(tooltipString);
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        Tooltip.HideTooltipStatic();
    }
}
