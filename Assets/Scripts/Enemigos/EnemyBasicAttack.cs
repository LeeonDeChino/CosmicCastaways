using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasicAttack : MonoBehaviour
{
    public int enemyDamage = 1;
    public float attackCooldown = 1.5f;
    private bool canAttack = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && canAttack)
        {
            other.GetComponent<PlayerCombat>().TakeDamage(enemyDamage);
            canAttack = false;
            Invoke("ResetAttack", attackCooldown);

        }
    }
    private void ResetAttack()
    {
        canAttack = true;
    }
}
