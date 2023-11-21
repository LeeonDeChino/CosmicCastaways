using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    // si el checkground colisiona con el suelo, el jugador puede saltar y si esta en el aire no puede saltar
    // crea una variable para el jugador
    public GameObject player;

    void Start()
    {
        // asigna el jugador
        player = GameObject.Find("Player");

    }

    // quiero que cuando el checkground colisione con el suelo, el jugador pueda saltar y si esta en el aire no puede saltar

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // si el checkground colisiona con el suelo, el jugador puede saltar y si esta en el aire no puede saltar
        if (collision.gameObject.tag == "Ground")
        {
            // el jugador puede saltar
            player.GetComponent<PlayerMovement>().isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // si el checkground colisiona con el suelo, el jugador puede saltar y si esta en el aire no puede saltar

        if (collision.gameObject.tag == "Ground")
        {
            // el jugador no puede saltar
            player.GetComponent<PlayerMovement>().isGrounded = false;
        }
    }
}
