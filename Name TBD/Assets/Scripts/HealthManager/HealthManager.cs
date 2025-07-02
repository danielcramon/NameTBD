using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    [SerializeField] protected int currentHealth;
    public int maxHealth;


    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    protected virtual void Update()
    {
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        
    }
}
