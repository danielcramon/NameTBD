using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : HealthManager
{
    protected override void Start()
    {
        maxHealth = gameObject.GetComponent<Enemy>().GetHealth();
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }
    protected override void Die()
    {
        Destroy(gameObject);
    }
}
