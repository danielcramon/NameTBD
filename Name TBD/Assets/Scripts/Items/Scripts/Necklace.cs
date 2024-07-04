using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Necklace : EquipmentObject
{


    private void Awake()
    {
        equipmentType = EquipmentType.Necklace;
    }

    public override bool Activate()
    {
        return true;
    }
}
