using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public int health;
    [SerializeField] private int maxHealth = 5;
    private bool isDead = false;

    private void Start()
    {
        health = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        if (!isDead)
        {
            health -= damage;
            Debug.Log("Ouch!");

        }
        if (health <= 0 && !isDead)
        {
            PlayerDeath();
        }
    }
    private void PlayerDeath()
    {
        isDead = true;
        gameObject.SetActive(false);
        Debug.Log("Moriste");
    }
}
