using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PrimaryAttribute
{
    Strength,
    Intellect,
    Agility,
    Stamina
}

public enum SecondaryAttribute
{
    CritChance,
    CritDamage,
    MovementSpeed,
    MagicFind,
}

public enum UniqueEffect
{
    AOEBurn,

}

public class Weapon : Item
{

    int baseDamage;

    PrimaryAttribute primary1;
    PrimaryAttribute primary2;
    float primary1Value;
    float primary2Value;

    SecondaryAttribute secondary1;
    SecondaryAttribute secondary2;
    float secondary1Value;
    float secondary2Value;

    UniqueEffect unique;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
