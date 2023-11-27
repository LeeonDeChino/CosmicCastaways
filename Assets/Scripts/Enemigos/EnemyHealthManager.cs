using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public int health;
    public int maxHealth = 3;
    Animator enemyAnimator;
    public bool isDead = false;
    EnemyDamageEffect damageEffect;
    void Start()
    {
        health = maxHealth;
        enemyAnimator = GetComponent<Animator>();
        damageEffect = GetComponent<EnemyDamageEffect>();
    }

    public void TakeDamage(int damage)
    {
        if (!isDead)
        {
            health -= damage;
            damageEffect.VFXDamage();

            if (health <= 0f)
            {
                EnemyDeath();
            }
        }

    }

    private void EnemyDeath()
    {
        isDead = true;
        enemyAnimator.SetTrigger("death");
    }

    public void Desactivar()
    {
        gameObject.SetActive(false);
    }
}
