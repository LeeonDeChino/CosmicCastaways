using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    // si el checkground colisiona con el suelo, el jugador puede saltar y si esta en el aire no puede saltar
    // crea una variable para el jugador
    public GameObject player;
    // crea una variable para el controlador de disparo
    public GameObject shootController;

    // Start is called before the first frame update

    void Start()
    {
        // asigna el jugador
        player = GameObject.Find("Player");
        // asigna el controlador de disparo
        shootController = GameObject.Find("ShootController");
    }

    // Update is called once per frame

    void Update()
    {
        
    }

    // quiero que cuando el checkground colisione con el suelo, el jugador pueda saltar y si esta en el aire no puede saltar

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // si el checkground colisiona con el suelo, el jugador puede saltar y si esta en el aire no puede saltar
        if (collision.gameObject.tag == "Ground")
        {
            // el jugador puede saltar
            player.GetComponent<PlayerController>().isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // si el checkground colisiona con el suelo, el jugador puede saltar y si esta en el aire no puede saltar

        if (collision.gameObject.tag == "Ground")
        {
            // el jugador no puede saltar
            player.GetComponent<PlayerController>().isGrounded = false;
        }
    }
}
