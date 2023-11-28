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
        AudioManager.instance.StartMusic();

    }
    public void TakeDamage(int damage)
    {
        if (!isDead)
        {
            health -= damage;
            barraDeVida.CambiarVidaActual(health);
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
       // sonido
    }

    public void DesactivarPlayer()
    {
        gameObject.SetActive(false);
    }

    //a�adir vida al jugador

    public void AddHealth(int healthToAdd)
    {
        health += healthToAdd;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        barraDeVida.CambiarVidaActual(health);
    }
}
