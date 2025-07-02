using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public Sprite characterSprite;
    public GameObject weapon;
    public PlayerStats stats;
    [SerializeField] PlayerController controller;

    [SerializeField] float strengthToWeaponDamage;
    [SerializeField] float staminaToMaxHealth;
    [SerializeField] float agilityToCritDamage;
    [SerializeField] float intellectToSpellDamage;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(weapon != null)
            {
                weapon.GetComponent<MeleeWeapon>().Attack();
            }
        }
    }

    public void CalculateSecondaries()
    {
        Debug.Log("Test");
        stats.combinedDamage += (int)(stats.combinedStrength * strengthToWeaponDamage);
        stats.combinedHealth += (int)(stats.combinedStamina * staminaToMaxHealth);
        stats.combinedCritDamage += (int)(stats.combinedAbility * agilityToCritDamage);
        stats.combinedSpellDamage += (int)(stats.combinedIntellect * intellectToSpellDamage);

        controller.SetMovementSpeed(stats.combinedMovementSpeed / 20);
    }
}
