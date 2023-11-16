using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MB_WalkBehaviour : StateMachineBehaviour
{

    Transform player;
    MiniBoss miniboss;
    private Rigidbody2D minibossRB;
    [SerializeField] float minibossSpeed = 2f;
    [SerializeField] float attackRange = 3f;

    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        miniboss = animator.GetComponent<MiniBoss>();
        minibossRB = animator.GetComponent<Rigidbody2D>();
        player = miniboss.playerPos;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        miniboss.LookAtPlayer();

        Vector2 target = new Vector2(player.position.x, minibossRB.position.y);
        Vector2 newPos = Vector2.MoveTowards(minibossRB.position, target, minibossSpeed * Time.fixedDeltaTime);
        minibossRB.MovePosition(newPos);

        if (Vector2.Distance(player.position, minibossRB.position) <= attackRange)
        {
            animator.SetTrigger("attack");
        }
    }

    //OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("attack");
    }
}
