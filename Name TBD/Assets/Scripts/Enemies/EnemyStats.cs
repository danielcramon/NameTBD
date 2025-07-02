using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyStats", menuName = "Enemies/EnemyStats")]
public class EnemyStats : ScriptableObject
{
    public int maxHealth;
    public int damage;
}
