using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator animator;
    PlayerMovement player;
    private bool isGrounded;
    public ArduinoInput input;
    public ControllerInput control;
    private int joystickV;
    float boton2;
    float val;

    private void Awake()
    {
        player = GetComponent<PlayerMovement>();
    }
    void Update()
    {
        joystickV = input.joystickValue;
        val = control.axisH;
        isGrounded = player.isGrounded;

        animator.SetBool("isFalling", !isGrounded);

        if (joystickV == 0 && control.axisH == 0)
        {
            animator.SetBool("moving", false);
            DisparoQuieto();
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
        boton2 = control.boton2;
        if (input.button2Value == 1 || boton2 == 1)
            animator.SetFloat("disparando", 1);
        else
            animator.SetFloat("disparando", 0);
    }

    public void DisparoQuieto()
    {
        boton2 = control.boton2;
        if (input.button2Value == 1 || boton2 == 1)
            animator.SetFloat("disparoQuieto", 1);
        else
            animator.SetFloat("disparoQuieto", 0);
    }
}
