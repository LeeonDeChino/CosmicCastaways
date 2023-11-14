using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeAttack : MonoBehaviour
{
    private int slimeDamage = 1;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerCombat>().TakeDamage(slimeDamage);
            //DesactivarObjeto();

        }

        if (other.CompareTag("Bullet"))
        {
            //Daño slime
            DesactivarObjeto();

        }
    }

    private void Attack()
    {

    }


    public void DesactivarObjeto()
    {
        gameObject.SetActive(false);
    }

    
}
