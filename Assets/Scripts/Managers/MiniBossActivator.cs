using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBossActivator : MonoBehaviour
{
    public Animator minibossAnimator;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            minibossAnimator.SetTrigger("activate");
            gameObject.SetActive(false);
        }
    }
}
