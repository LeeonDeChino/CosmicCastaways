using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public ArduinoInput input;
    private int val;
    private int jumpButtonVal;
    PlayerLookDirection playerLookDirection;
    PlayerAnimations playerAnimations;
  
    [SerializeField] float playerSpeed = 5f;
    Rigidbody2D playerRB;
    [SerializeField] float jumpForce = 4f;
    public bool isGrounded;
    

    private void Start()
    {
        playerRB = GetComponent<Rigidbody2D>(); 
        playerLookDirection = GetComponent<PlayerLookDirection>();
        playerAnimations = GetComponent<PlayerAnimations>();
    }

    private void FixedUpdate()
    {
        //Este es el valor que recibimos del Arduino en el script de ArduinoInput.
        
        val = input.joystickValue;
        jumpButtonVal = input.buttonValue;

       

        //MOVIMIENTO
        Move();
        

        //SALTO
        if (jumpButtonVal == 1)
        {
            Jump();
        }

    }

    void Move()
    {
        if(val <= 450)
        {
            transform.Translate(Vector3.left * Time.fixedDeltaTime * playerSpeed);
            playerLookDirection.LookDirection(-1);
        }
        else if (val >= 530)
        {
            transform.Translate(Vector3.right * Time.fixedDeltaTime * playerSpeed);
            playerLookDirection.LookDirection(1);
        }
        else
        {
            playerLookDirection.LookDirection(1);

        }

    }
    void Jump()
    {
        if (isGrounded)
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, jumpForce);
            playerAnimations.TriggerJump();

        }   
    }

    
}
