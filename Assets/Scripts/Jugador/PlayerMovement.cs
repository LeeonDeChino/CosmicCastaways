using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public ArduinoInput input;
    private int val;
    [SerializeField] float playerSpeed = 5f;
    Rigidbody2D playerRB;
    [SerializeField] float jumpForce = 4f;

    private void Start()
    {
        playerRB = GetComponent<Rigidbody2D>(); 
    }

    private void FixedUpdate()
    {
        val = input.value;
        Debug.Log(val);
        if (val < 2)
        {
            transform.Translate(Vector3.right * val * Time.deltaTime * playerSpeed);
            //move
        }
        if (val == 2)
        {
            Jump();
        }
        if (val == 3)
        {
            Debug.Log("Shoot");
            //shoot
        }
    }

    void Jump()
    {
        playerRB.velocity = new Vector2(playerRB.velocity.x, jumpForce);
    }
}
