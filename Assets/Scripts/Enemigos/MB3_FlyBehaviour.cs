using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MB3_FlyBehaviour : StateMachineBehaviour
{
    public float bossSpeed;
    float range;
    float shootRange;
    
    MiniBoss3 script;
    Transform player;
    Transform boss;
    Animator bossAnimator;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        script = animator.GetComponent<MiniBoss3>();
        boss = animator.GetComponent<Transform>();
        bossAnimator = animator.GetComponent<Animator>();   
        player = script.player;
        range = script.range;
        shootRange = script.shootRange;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Rotación
        Vector2 moveDir = (player.position - boss.position).normalized;
        float rot = Mathf.Atan2(-moveDir.y, -moveDir.x) * Mathf.Rad2Deg;
        boss.rotation = Quaternion.Euler(0, 0, rot);

        //Movimiento
        float distanceFromPlayer = Vector2.Distance(player.position, boss.position);

        if(distanceFromPlayer < range && distanceFromPlayer > shootRange)
        {
            boss.position = Vector2.MoveTowards(boss.position, player.position, bossSpeed * Time.deltaTime);
        }
        else if (distanceFromPlayer <= shootRange)
        {
            //Disparo
            bossAnimator.SetTrigger("attack");
        }
    }

    //OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        bossAnimator.ResetTrigger("attack");
    }
}
