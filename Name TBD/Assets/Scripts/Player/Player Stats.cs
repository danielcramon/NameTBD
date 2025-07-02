using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //Base Stats
    [SerializeField] int baseHealth;
    [SerializeField] int baseDamage;

    [SerializeField] int baseStrength;
    [SerializeField] int baseStamina;
    [SerializeField] int baseAgility;
    [SerializeField] int baseIntellect;

    [SerializeField] int baseCritChance;
    [SerializeField] int baseCritDamage;
    [SerializeField] int baseMagicFind;
    [SerializeField] int baseMovementSpeed;
    [SerializeField] int baseSpellDamage;

    List<UniqueEffect> effects;

    //Combined Stats
    public int combinedHealth;
    public int combinedDamage;

    public int combinedStrength;
    public int combinedStamina;
    public int combinedAbility;
    public int combinedIntellect;

    public int combinedCritChance;
    public int combinedCritDamage;
    public int combinedMagicFind;
    public int combinedMovementSpeed;
    public int combinedSpellDamage;

    private void Awake()
    {
        combinedHealth = baseHealth;
        combinedDamage = baseDamage;

        combinedStrength = baseStrength;
        combinedStamina = baseStamina;
        combinedAbility = baseAgility;
        combinedIntellect = baseIntellect;

        combinedCritChance = baseCritChance;
        combinedCritDamage = baseCritDamage;
        combinedMagicFind = baseMagicFind;
        combinedMovementSpeed = baseMovementSpeed;
        combinedSpellDamage = baseSpellDamage;

        gameObject.GetComponent<PlayerHealthManager>().SetHealth(combinedHealth);
    }

    public void UpdateStats(List<InventoryObjects> equipment)
    {
        //Reset Stats;
        combinedHealth = baseHealth;
        combinedDamage = baseDamage;

        combinedStrength = baseStrength;
        combinedStamina = baseStamina;
        combinedAbility = baseAgility;
        combinedIntellect = baseIntellect;

        combinedCritChance = baseCritChance;
        combinedCritDamage = baseCritDamage;
        combinedMagicFind = baseMagicFind;
        combinedMovementSpeed = baseMovementSpeed;

        effects = new List<UniqueEffect>();

        foreach (EquipmentObject item in equipment)
        {
            if(item != null)
            {
                combinedDamage += item.baseDamage;
                switch (item.primary1)
                {
                    case PrimaryAttribute.Strength:
                        combinedStrength += item.primary1Value;
                        break;
                    case PrimaryAttribute.Intellect:
                        combinedIntellect += item.primary1Value;
                        break;
                    case PrimaryAttribute.Agility:
                        combinedAbility += item.primary1Value;
                        break;
                    case PrimaryAttribute.Stamina:
                        combinedStamina += item.primary1Value;
                        break;
                    case PrimaryAttribute.None:
                        break;
                    default:
                        break;
                }
                switch (item.primary2)
                {
                    case PrimaryAttribute.Strength:
                        combinedStrength += item.primary2Value;
                        break;
                    case PrimaryAttribute.Intellect:
                        combinedIntellect += item.primary2Value;
                        break;
                    case PrimaryAttribute.Agility:
                        combinedAbility += item.primary2Value;
                        break;
                    case PrimaryAttribute.Stamina:
                        combinedStamina += item.primary2Value;
                        break;
                    case PrimaryAttribute.None:
                        break;
                    default:
                        break;
                }
                switch (item.secondary1)
                {
                    case SecondaryAttribute.CritChance:
                        combinedCritChance += item.secondary1Value;
                        break;
                    case SecondaryAttribute.CritDamage:
                        combinedCritDamage += item.secondary1Value;
                        break;
                    case SecondaryAttribute.MovementSpeed:
                        combinedMovementSpeed += item.secondary1Value;
                        break;
                    case SecondaryAttribute.MagicFind:
                        combinedMagicFind += item.secondary1Value;
                        break;
                    case SecondaryAttribute.SpellDamage:
                        combinedSpellDamage += item.secondary1Value;
                        break;
                    case SecondaryAttribute.None:
                        break;
                    default:
                        break;
                }
                switch (item.secondary2)
                {
                    case SecondaryAttribute.CritChance:
                        combinedCritChance += item.secondary2Value;
                        break;
                    case SecondaryAttribute.CritDamage:
                        combinedCritDamage += item.secondary2Value;
                        break;
                    case SecondaryAttribute.MovementSpeed:
                        combinedMovementSpeed += item.secondary2Value;
                        break;
                    case SecondaryAttribute.MagicFind:
                        combinedMagicFind += item.secondary2Value;
                        break;
                    case SecondaryAttribute.SpellDamage:
                        combinedSpellDamage += item.secondary2Value;
                        break;
                    case SecondaryAttribute.None:
                        break;
                    default:
                        break;
                }

                if (item.unique != UniqueEffect.None && !effects.Contains(item.unique))
                {
                    effects.Add(item.unique);
                }
            }
        }

        gameObject.GetComponent<PlayerHealthManager>().SetHealth(combinedHealth);
    }
}
