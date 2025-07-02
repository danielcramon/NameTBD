using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TooltipItem : MonoBehaviour
{
    private static TooltipItem instance;

    [SerializeField] Camera uiCamera;


    [SerializeField] TextMeshProUGUI stat1;
    [SerializeField] TextMeshProUGUI stat2;
    [SerializeField] TextMeshProUGUI stat3;
    [SerializeField] TextMeshProUGUI stat4;
    [SerializeField] TextMeshProUGUI uniqueEffect;
    [SerializeField] TextMeshProUGUI itemName;
    [SerializeField] TextMeshProUGUI discription;

    [SerializeField] Image itemImage;

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

    private void ShowTooltip(EquipmentObject equipmentItem)
    {
        gameObject.SetActive(true);

        itemImage.sprite = equipmentItem.gameObject.GetComponent<Image>().sprite;

        stat1.text = "";
        stat2.text = "";
        stat3.text = "";
        stat4.text = "";
        uniqueEffect.text = "";

        itemName.text = equipmentItem.itemName;
        switch (equipmentItem.primary1)
        {
            case PrimaryAttribute.Strength:
                stat1.text = "Strength: " + equipmentItem.primary1Value;
                break;
            case PrimaryAttribute.Intellect:
                stat1.text = "Intellect: " + equipmentItem.primary1Value;
                break;
            case PrimaryAttribute.Agility:
                stat1.text = "Agility: " + equipmentItem.primary1Value;
                break;
            case PrimaryAttribute.Stamina:
                stat1.text = "Stamina: " + equipmentItem.primary1Value;
                break;
            case PrimaryAttribute.None:
                break;
            default:
                break;
        }

        if(equipmentItem.primary2 != PrimaryAttribute.None)
        {
            switch (equipmentItem.primary2)
            {
                case PrimaryAttribute.Strength:
                    stat2.text = "Strength: " + equipmentItem.primary2Value;
                    break;
                case PrimaryAttribute.Intellect:
                    stat2.text = "Intellect: " + equipmentItem.primary2Value;
                    break;
                case PrimaryAttribute.Agility:
                    stat2.text = "Agility: " + equipmentItem.primary2Value;
                    break;
                case PrimaryAttribute.Stamina:
                    stat2.text = "Stamina: " + equipmentItem.primary2Value;
                    break;
                case PrimaryAttribute.None:
                    break;
                default:
                    break;
            }
            switch (equipmentItem.secondary1)
            {
                case SecondaryAttribute.CritChance:
                    stat3.text = "Crit Chance " + equipmentItem.secondary1Value;
                    break;
                case SecondaryAttribute.CritDamage:
                    stat3.text = "Crit Damage " + equipmentItem.secondary1Value;
                    break;
                case SecondaryAttribute.MovementSpeed:
                    stat3.text = "Movement Speed " + equipmentItem.secondary1Value;
                    break;
                case SecondaryAttribute.MagicFind:
                    stat3.text = "Magic Find " + equipmentItem.secondary1Value;
                    break;
                case SecondaryAttribute.SpellDamage:
                    stat3.text = "Spell Damage " + equipmentItem.secondary1Value;
                    break;
                case SecondaryAttribute.None:
                    break;
                default:
                    break;
            }

            if (equipmentItem.secondary2 != SecondaryAttribute.None)
            {
                switch (equipmentItem.secondary2)
                {
                    case SecondaryAttribute.CritChance:
                        stat4.text = "Crit Chance " + equipmentItem.secondary2Value;
                        break;
                    case SecondaryAttribute.CritDamage:
                        stat4.text = "Crit Damage " + equipmentItem.secondary1Value;
                        break;
                    case SecondaryAttribute.MovementSpeed:
                        stat4.text = "Movement Speed " + equipmentItem.secondary2Value;
                        break;
                    case SecondaryAttribute.MagicFind:
                        stat4.text = "Magic Find " + equipmentItem.secondary2Value;
                        break;
                    case SecondaryAttribute.SpellDamage:
                        stat4.text = "Spell Damage " + equipmentItem.secondary2Value;
                        break;
                    case SecondaryAttribute.None:
                        break;
                    default:
                        break;
                }
            }
        }
        else
        {
            switch (equipmentItem.secondary1)
            {
                case SecondaryAttribute.CritChance:
                    stat2.text = "Crit Chance " + equipmentItem.secondary1Value;
                    break;
                case SecondaryAttribute.CritDamage:
                    stat2.text = "Crit Damage " + equipmentItem.secondary1Value;
                    break;
                case SecondaryAttribute.MovementSpeed:
                    stat2.text = "Movement Speed " + equipmentItem.secondary1Value;
                    break;
                case SecondaryAttribute.MagicFind:
                    stat2.text = "Magic Find " + equipmentItem.secondary1Value;
                    break;
                case SecondaryAttribute.SpellDamage:
                    stat2.text = "Spell Damage " + equipmentItem.secondary1Value;
                    break;
                case SecondaryAttribute.None:
                    break;
                default:
                    break;
            }

            if(equipmentItem.secondary2 != SecondaryAttribute.None)
            {
                switch (equipmentItem.secondary2)
                {
                    case SecondaryAttribute.CritChance:
                        stat3.text = "Crit Chance " + equipmentItem.secondary2Value;
                        break;
                    case SecondaryAttribute.CritDamage:
                        stat3.text = "Crit Damage " + equipmentItem.secondary1Value;
                        break;
                    case SecondaryAttribute.MovementSpeed:
                        stat3.text = "Movement Speed " + equipmentItem.secondary2Value;
                        break;
                    case SecondaryAttribute.MagicFind:
                        stat3.text = "Magic Find " + equipmentItem.secondary2Value;
                        break;
                    case SecondaryAttribute.SpellDamage:
                        stat3.text = "Spell Damage " + equipmentItem.secondary2Value;
                        break;
                    case SecondaryAttribute.None:
                        break;
                    default:
                        break;
                }
            }

        }

        if(equipmentItem.unique != UniqueEffect.None)
        {
            uniqueEffect.text = equipmentItem.unique.ToString();
        }

        discription.text = equipmentItem.description;
    }

    private void HideTooltip()
    {
        gameObject.SetActive(false);
    }

    public static void ShowTooltipStatic(EquipmentObject equipmentItem)
    {
        instance.ShowTooltip(equipmentItem);
    }

    public static void HideTooltipStatic()
    {
        instance.HideTooltip();
    }
}
