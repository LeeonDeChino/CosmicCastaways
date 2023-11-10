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

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        Vector3 movement = new Vector3(move.x, 0f, move.y);

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

    // agregar que pueda saltar con el boton space

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Jump();
        }
    }

    public void Jump()
    {
        // si esta en el suelo es true puede saltar si no es false

        if (isGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
        else
        {
            isGrounded = true;
        }
    }
    // agregar que pueda disparar con la tecla F

    public void OnFire(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Fire();
        }
    }

    public void Fire()
    {
        Debug.Log("Fire");
    }


}