using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boots : EquipmentObject
{

    private void Awake()
    {
        equipmentType = EquipmentType.Boots;
    }

    public override bool Activate()
    {
        return true;
    }
}
