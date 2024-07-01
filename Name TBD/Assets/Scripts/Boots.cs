using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boots : Item
{
    PrimaryAttribute primary;
    float primaryValue;

    SecondaryAttribute secondary1;
    SecondaryAttribute secondary2 = SecondaryAttribute.MovementSpeed;
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
