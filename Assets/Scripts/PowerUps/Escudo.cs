using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escudo : MonoBehaviour
{
    // CUANDO EL JUGADOR CHOCA CON EL ESCUDO SE DESTRUYE

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // añade vida al jugador usando el script PlayerCombat
            collision.gameObject.GetComponent<PlayerCombat>().AddHealth(1);
            // se desactiva el escudo
            gameObject.SetActive(false);
        }
    }
}
