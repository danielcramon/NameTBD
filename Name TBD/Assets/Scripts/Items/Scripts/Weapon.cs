using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PrimaryAttribute
{
    Strength,
    Intellect,
    Agility,
    Stamina,
    None
}

public enum SecondaryAttribute
{
    CritChance,
    CritDamage,
    MovementSpeed,
    MagicFind,
    None
}

public enum UniqueEffect
{
    None,
    AOEBurn,

}


public class Weapon : EquipmentObject
{
    public Vector3 ancorPosition;
    public Quaternion ancorRotation;
    public GameObject weapon;

    private void Awake()
    {
        equipmentType = EquipmentType.Weapon;
    }

    public override bool Activate()
    {
        return true;
    }
}
