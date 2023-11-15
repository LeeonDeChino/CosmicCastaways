using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBoss : MonoBehaviour
{
    public PlayerCombat playerScript;
    public Transform playerPos;
    private int damage = 2;
    public int health; 
    private int maxHealth = 10;
    public bool isFlipped = false;

    private void Start()
    {
        health = maxHealth;
    }

    public void MiniBossAttack()
    {
        playerScript.TakeDamage(damage);
    }
    public void LookAtPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        if(transform.position.x > playerPos.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = false;
        }
        else if (transform.position.x < playerPos.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;
        }
    }
}
