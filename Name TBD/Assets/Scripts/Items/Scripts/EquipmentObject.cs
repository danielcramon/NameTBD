using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EquipmentObject : InventoryObjects
{
    public int baseDamage;

    public PrimaryAttribute primary1;
    public int primary1Value;
    [SerializeField] int primary1RangeMin;
    [SerializeField] int primary1RangeMax;

    public PrimaryAttribute primary2;
    public int primary2Value;
    [SerializeField] int primary2RangeMin;
    [SerializeField] int primary2RangeMax;

    public SecondaryAttribute secondary1;
    public int secondary1Value;
    [SerializeField] int secondary1RangeMin;
    [SerializeField] int secondary1RangeMax;

    public SecondaryAttribute secondary2;
    public int secondary2Value;
    [SerializeField] int secondary2RangeMin;
    [SerializeField] int secondary2RangeMax;

    public UniqueEffect unique;

    private void Awake()
    {
        type = Type.Equipment;
    }

    public void setValue()
    {
        if(primary1 != PrimaryAttribute.None)
        {
            primary1Value = Random.Range(primary1RangeMin, primary1RangeMax);
        }
        if (primary2 != PrimaryAttribute.None)
        {
            primary2Value = Random.Range(primary2RangeMin, primary2RangeMax);
        }
        if (secondary1 != SecondaryAttribute.None)
        {
            secondary1Value = Random.Range(secondary1RangeMin, secondary1RangeMax);
        }
        if (secondary2 != SecondaryAttribute.None)
        {
            secondary2Value = Random.Range(secondary2RangeMin, secondary2RangeMax);
        }
    }
}
