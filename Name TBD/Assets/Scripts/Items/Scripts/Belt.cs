using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Belt : EquipmentObject
{

    private void Awake()
    {
        equipmentType = EquipmentType.Belt;
    }

    public override bool Activate()
    {
        return true;
    }
}
