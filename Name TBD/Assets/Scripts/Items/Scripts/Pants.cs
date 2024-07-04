using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pants : EquipmentObject
{

    private void Awake()
    {
        equipmentType = EquipmentType.Pants;
    }

    public override bool Activate()
    {
        return true;
    }
}
