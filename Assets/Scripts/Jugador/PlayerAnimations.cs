using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator animator;
    PlayerMovement player;
    private bool isGrounded;
    public ArduinoInput input;
    private int joystickV;

    // Update is called once per frame

    private void Awake()
    {
        player = GetComponent<PlayerMovement>();
    }
    void Update()
    {
        joystickV = input.joystickValue;

        isGrounded = player.isGrounded;

        animator.SetBool("isFalling", !isGrounded);

        if (joystickV == 0)
        {
            animator.SetBool("moving", false);
        }
        else
        {
            animator.SetBool("moving", true);
        }
        
    }

    public void TriggerJump()
    {
        animator.SetTrigger("jump");
    }

    public void DisparoAnimacion()
    {
        if (input.button2Value == 1)
            animator.SetFloat("disparando", 1);
        else
            animator.SetFloat("disparando", 0);
    }
}
