using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tooltip : MonoBehaviour
{
    private static Tooltip instance;

    [SerializeField] Camera uiCamera;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] RectTransform backgroundRectTransform;

    private void Awake()
    {
        instance = this;
        instance.HideTooltip();
    }

    private void Update()
    {
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.parent.GetComponent<RectTransform>(), Input.mousePosition, uiCamera, out localPoint);
        transform.localPosition = localPoint;
    }

    private void ShowTooltip(string toolTipString)
    {
        gameObject.SetActive(true);

        text.text = toolTipString;
        float textPaddingSize = 4f;
        Vector2 backgroundSize = new Vector2(text.preferredWidth + textPaddingSize * 2, text.preferredHeight + textPaddingSize * 2);
        backgroundRectTransform.sizeDelta = backgroundSize;
    }

    private void HideTooltip()
    {
        gameObject.SetActive(false);
    }

    public static void ShowTooltipStatic(string tooltipString)
    {
        instance.ShowTooltip(tooltipString);
    }

    public static void HideTooltipStatic()
    {
        instance.HideTooltip();
    }
}
