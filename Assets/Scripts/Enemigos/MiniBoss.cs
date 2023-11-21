using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBoss : MonoBehaviour
{
    public PlayerCombat playerScript;
    public int attackDamage = 2;
    public Vector3 attackOffset;
    public float attackRange = 1f;
    public LayerMask attackMask;

    public GameManager gameManager;
    void OnDrawGizmosSelected()
    {
        // Calcula la posición del punto de ataque
        Vector3 pos = transform.position;
        pos += transform.right * attackOffset.x;
        pos += transform.up * attackOffset.y;

        // Dibuja un gizmo esférico para representar el área de ataque
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(pos, attackRange);
    }
    public void MiniBossAttack()
    {
        Vector3 pos = transform.position;
        pos += transform.right * attackOffset.x;
        pos += transform.up * attackOffset.x;

        Collider2D colInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);

        if (colInfo != null)
        {
            playerScript.TakeDamage(attackDamage);
            Debug.Log("Boss Hit");
        }
        
    }

    public void LiberarCastaway()
    {
        gameManager.LiberarCastaways(1);
    }
}
