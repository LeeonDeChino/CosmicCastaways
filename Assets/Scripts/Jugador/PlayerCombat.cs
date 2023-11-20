using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public int health;
    [SerializeField] private int maxHealth = 5;
    private bool isDead = false;
    [SerializeField] private GameManager gameManager;
    [SerializeField] BarraDeVidaPlayer barraDeVida;

    private void Start()
    {
        health = maxHealth;
        barraDeVida.InicializarBarraDeVida(health);
    }
    public void TakeDamage(int damage)
    {
        if (!isDead)
        {
            health -= damage;
            barraDeVida.CambiarVidaActual(health);
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
        Invoke("DesactivarPlayer", 1f);
        gameManager.GameOver();
    }

    public void DesactivarPlayer()
    {
        gameObject.SetActive(false);
    }
}
