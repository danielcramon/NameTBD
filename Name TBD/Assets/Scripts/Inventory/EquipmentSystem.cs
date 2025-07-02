using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EquipmentSystem : MonoBehaviour
{
    [SerializeField] List<InventoryObjects> equipmentObjects = new List<InventoryObjects>();
    [SerializeField] InventorySystem inventory;
    [SerializeField] Character playerCharacter;
    [SerializeField] GameObject weaponAncorPosition;

    private void Start()
    {
        if(playerCharacter != null)
        {
            playerCharacter.CalculateSecondaries();
        }
        UpdateStats();
        transform.GetChild(8).GetComponent<Image>().sprite = playerCharacter.characterSprite;
    }
    public void AddEquipment(InventoryObjects obj)
    {
        switch (obj.equipmentType)
        {
            case EquipmentType.Necklace:
                if(transform.GetChild(0).childCount != 0)
                {
                    inventory.AddItem(equipmentObjects[0]);
                    Destroy(transform.GetChild(0).GetChild(0).gameObject);
                    Instantiate(obj, transform.GetChild(0));
                    equipmentObjects[0] = obj;
                }
                else
                {
                    Instantiate(obj, transform.GetChild(0));
                    equipmentObjects[0] = obj;
                }
                break;
            case EquipmentType.Chest:
                if (transform.GetChild(1).childCount != 0)
                {
                    inventory.AddItem(equipmentObjects[1]);
                    Destroy(transform.GetChild(1).GetChild(0).gameObject);
                    Instantiate(obj, transform.GetChild(1));
                    equipmentObjects[1] = obj;
                }
                else
                {
                    Instantiate(obj, transform.GetChild(1));
                    equipmentObjects[1] = obj;
                }
                break;
            case EquipmentType.Ring:
                if (transform.GetChild(2).childCount != 0)
                {
                    inventory.AddItem(equipmentObjects[2]);
                    Destroy(transform.GetChild(2).GetChild(0).gameObject);
                    Instantiate(obj, transform.GetChild(2));
                    equipmentObjects[2] = obj;
                }
                else
                {
                    Instantiate(obj, transform.GetChild(2));
                    equipmentObjects[2] = obj;
                }
                break;
            case EquipmentType.Weapon:
                if (transform.GetChild(3).childCount != 0)
                {
                    inventory.AddItem(equipmentObjects[3]);
                    Destroy(transform.GetChild(3).GetChild(0).gameObject);
                    Destroy(weaponAncorPosition.transform.GetChild(0).gameObject);
                    Instantiate(obj, transform.GetChild(3));
                    GameObject temp = Instantiate(obj.GetComponent<Weapon>().weapon, weaponAncorPosition.transform);
                    playerCharacter.weapon = temp;
                    equipmentObjects[3] = obj;
                }
                else
                {
                    Instantiate(obj, transform.GetChild(3));
                    GameObject temp = Instantiate(obj.GetComponent<Weapon>().weapon, weaponAncorPosition.transform);
                    playerCharacter.weapon = temp;
                    equipmentObjects[3] = obj;
                }
                break;
            case EquipmentType.Belt:
                if (transform.GetChild(4).childCount != 0)
                {
                    inventory.AddItem(equipmentObjects[4]);
                    Destroy(transform.GetChild(4).GetChild(0).gameObject);
                    Instantiate(obj, transform.GetChild(4));
                    equipmentObjects[4] = obj;
                }
                else
                {
                    Instantiate(obj, transform.GetChild(4));
                    equipmentObjects[4] = obj;
                }
                break;
            case EquipmentType.Pants:
                if (transform.GetChild(5).childCount != 0)
                {
                    inventory.AddItem(equipmentObjects[5]);
                    Destroy(transform.GetChild(5).GetChild(0).gameObject);
                    Instantiate(obj, transform.GetChild(5));
                    equipmentObjects[5] = obj;
                }
                else
                {
                    Instantiate(obj, transform.GetChild(5));
                    equipmentObjects[5] = obj;
                }
                break;
            case EquipmentType.Boots:
                if (transform.GetChild(6).childCount != 0)
                {
                    inventory.AddItem(equipmentObjects[6]);
                    Destroy(transform.GetChild(6).GetChild(0).gameObject);
                    Instantiate(obj, transform.GetChild(6));
                    equipmentObjects[6] = obj;
                }
                else
                {
                    Instantiate(obj, transform.GetChild(6));
                    equipmentObjects[6] = obj;
                }
                break;
        }

        playerCharacter.stats.UpdateStats(equipmentObjects);
        playerCharacter.CalculateSecondaries();
        if(playerCharacter.weapon != null)
        {
            playerCharacter.weapon.GetComponent<MeleeWeapon>().SetDamage(playerCharacter.stats.combinedDamage);
        }
        UpdateStats();
    }

    private void UpdateStats()
    {
        transform.GetChild(7).GetChild(0).GetComponent<TextMeshProUGUI>().text = "Health: " + playerCharacter.stats.combinedHealth;
        transform.GetChild(7).GetChild(1).GetComponent<TextMeshProUGUI>().text = "Damage: " + playerCharacter.stats.combinedDamage;
        transform.GetChild(7).GetChild(2).GetComponent<TextMeshProUGUI>().text = "Strength: " + playerCharacter.stats.combinedStrength;
        transform.GetChild(7).GetChild(3).GetComponent<TextMeshProUGUI>().text = "Stamina: " + playerCharacter.stats.combinedStamina;
        transform.GetChild(7).GetChild(4).GetComponent<TextMeshProUGUI>().text = "Agility: " + playerCharacter.stats.combinedAbility;
        transform.GetChild(7).GetChild(5).GetComponent<TextMeshProUGUI>().text = "Intellect: " + playerCharacter.stats.combinedIntellect;
        transform.GetChild(7).GetChild(6).GetComponent<TextMeshProUGUI>().text = "Crit Chance: " + playerCharacter.stats.combinedCritChance;
        transform.GetChild(7).GetChild(7).GetComponent<TextMeshProUGUI>().text = "Crit Damage: " + playerCharacter.stats.combinedCritDamage;
        transform.GetChild(7).GetChild(8).GetComponent<TextMeshProUGUI>().text = "Magic Find: " + playerCharacter.stats.combinedMagicFind;
        transform.GetChild(7).GetChild(9).GetComponent<TextMeshProUGUI>().text = "Move Speed: " + playerCharacter.stats.combinedMovementSpeed;
        transform.GetChild(7).GetChild(10).GetComponent<TextMeshProUGUI>().text = "Spell Damage: " + playerCharacter.stats.combinedSpellDamage;
    }
}
