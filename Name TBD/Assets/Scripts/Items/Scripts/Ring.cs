using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ring : EquipmentObject
{

    private void Awake()
    {
        equipmentType = EquipmentType.Ring;
    }

    public override bool Activate()
    {
        return true;
    }
}
