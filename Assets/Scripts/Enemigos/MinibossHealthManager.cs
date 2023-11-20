using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinibossHealthManager : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;
    Animator miniBossAnimator;
    private bool isDead = false;
    EnemyDamageEffect damageEffect;
    void Start()
    {
        health = maxHealth;
        miniBossAnimator = GetComponent<Animator>();    
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
                MiniBossDeath();
            }
        }  

    }

    private void MiniBossDeath()
    {
        isDead = true;
        miniBossAnimator.SetTrigger("death");
    }

    public void Desactivar()
    {
        gameObject.SetActive(false);
    }
}
