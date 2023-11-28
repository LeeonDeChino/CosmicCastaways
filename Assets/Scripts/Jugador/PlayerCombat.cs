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
    public GameObject errorMessage;

    private void Start()
    {
        health = maxHealth;
        barraDeVida.InicializarBarraDeVida(health);
        //AudioManager.instance.StartMusic();

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
        AudioManager.instance.PlayLose();
    }

    public void DesactivarPlayer()
    {
        gameObject.SetActive(false);
    }

    //añadir vida al jugador

    public void AddHealth(int healthToAdd)
    {
        health += healthToAdd;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        barraDeVida.CambiarVidaActual(health);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Limite"))
        {
            PlayerDeath();
        }
        if (other.CompareTag("Meta"))
        {
            if (gameManager.castawayCount == 3)
            {
                gameManager.LevelCompleted();
            }
            else
            {
                errorMessage.SetActive(true);
            }
            
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Meta") && errorMessage.activeInHierarchy)
        {
            errorMessage.SetActive(false);
        }
    }
}
