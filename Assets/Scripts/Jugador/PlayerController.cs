using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Vector2 move;
    public float jumpForce;
    public bool isGrounded;
    public SpriteRenderer sprite;
    // AGREGA ESTA VARIABLE PARA QUE EL JUGADOR PUEDA DISPARAR
    public GameObject bulletPrefab;
    // agrega el controlador de disparo
    public GameObject shootController;

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    // pasar el movineto a 2d Y EL SPRITE DEL JUGADOR SE VA A FLIP PARA QUE SE MUEVA EN LA DIRECCION QUE SE ESTA MOVIENDO

    void MovePlayer()
    {
        Vector3 movement = new Vector3(move.x, 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;

        if (move.x > 0)
        {
            sprite.flipX = false;
        }
        else if (move.x < 0)
        {
            sprite.flipX = true;
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Jump();
        }
    }

    public void Jump()
    {
        // SI isgrounded es true, activa la funcion de salto si no , no hace nada

        if (isGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            AudioManager.instance.PlayJump();
        }
    }

    // agregar que pueda disparar con la tecla F usando el input system shoot

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
          Fire();
        }
    }

    // llama a esta funcion para que el jugador pueda disparar un proyectil hacia donde el sprite este flippeado

    void Fire()
    {
        //Si el sprite esta flippeado, el proyectil se va a disparar hacia la izquierda y si no, se va a disparar hacia la derecha


        if (sprite.flipX == true)
        {
            // instanciar el proyectil en la posicion del jugador
            GameObject bullet = Instantiate(bulletPrefab, shootController.transform.position + Vector3.left, Quaternion.identity);
            // asignar la velocidad del proyectil
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(-10f, 0f);
        }
        else
        {
            // instanciar el proyectil en la posicion del jugador
            GameObject bullet = Instantiate(bulletPrefab, shootController.transform.position + Vector3.right, Quaternion.identity);
            // asignar la velocidad del proyectil
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 0f);
        }
    }
}