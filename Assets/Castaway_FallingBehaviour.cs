using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castaway_FallingBehaviour : StateMachineBehaviour
{
    private Transform castawayPos;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        castawayPos = animator.GetComponent<Transform>();
        castawayPos.position = new Vector3(castawayPos.position.x,castawayPos.position.y-1.25f,castawayPos.position.z);
    }

    //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
}
