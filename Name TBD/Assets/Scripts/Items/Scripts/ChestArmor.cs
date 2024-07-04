using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChestArmor : EquipmentObject
{


    private void Awake()
    {
        equipmentType = EquipmentType.Chest;
    }

    public override bool Activate()
    {
        return true;
    }
}
