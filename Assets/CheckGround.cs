using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    // AGREGA ESTA FUNCION PARA checar si el jugador esta en el suelo o no

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            GetComponentInParent<PlayerController>().isGrounded = true;
        }
        else
        {
            GetComponentInParent<PlayerController>().isGrounded = false;
        }
    }
}
