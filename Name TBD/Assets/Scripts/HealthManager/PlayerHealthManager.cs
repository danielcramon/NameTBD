using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : HealthManager
{
    public void SetHealth(int health)
    {
        maxHealth = health;
    }
}
