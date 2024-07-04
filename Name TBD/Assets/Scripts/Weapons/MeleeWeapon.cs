using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : MonoBehaviour
{
    int weaponDamage;
    [SerializeField] Animator anim;

    public void SetDamage(int damage)
    {
        weaponDamage = damage;
    }

    public void Attack()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        anim.SetBool("Attack", true);
        StartCoroutine(StopAttack());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Fighter")
        {
            collision.gameObject.GetComponent<HealthManager>().TakeDamage(weaponDamage);
        }
    }

    IEnumerator StopAttack()
    {
        yield return new WaitForSeconds(0.2f);
        anim.SetBool("Attack", false);
        yield return new WaitForSeconds(0.8f);
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
}
