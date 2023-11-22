using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator animator;
    public ArduinoInput input;

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("speed", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
        if (input.value != 0 && input.value < 2)
        {
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
        if(input.value == 2)
        {
            //salto
        }
        if (input.value == 3)
        {
            //disparo
        }
    }
}
