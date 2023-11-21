using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public ArduinoInput input;
    public DisparoV2 shoot;
    public PlayerLookDirection playerLookDirection;

    private int val;
    [SerializeField] float playerSpeed = 5f;
    Rigidbody2D playerRB;
    [SerializeField] float jumpForce = 4f;
    public bool isGrounded;
    

    private void Start()
    {
        playerRB = GetComponent<Rigidbody2D>(); 
    }

    private void FixedUpdate()
    {
        //Este es el valor que recibimos del Arduino en el script de ArduinoInput.
        val = input.value;
        Debug.Log(val);

        //DIRECCIÓN
        playerLookDirection.LookDirection(val);

        //MOVIMIENTO
        if (val < 2)
        {
            Move();
        }

        //SALTO
        if (val == 2)
        {
            Jump();
        }

        //DISPARO
        if (val == 3)
        {
            shoot.Disparar();
        }
    }

    void Move()
    {
        transform.Translate(Vector3.right * val * Time.fixedDeltaTime * playerSpeed);
    }
    void Jump()
    {
        if (isGrounded)
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, jumpForce);
        }   
    }

    
}
