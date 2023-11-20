using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castaway_WalkBehaviour : StateMachineBehaviour
{
    Transform castawayPos;
    public float castawaySpeed = 1.5f;
    CastawayManager castawayManager;
   
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        castawayPos = animator.GetComponent<Transform>();
        castawayManager = animator.GetComponent<CastawayManager>(); 
        castawayManager.DesactivarCastaway();     
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        castawayPos.Translate(Vector2.left * castawaySpeed * Time.fixedDeltaTime);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

}
