using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctopusAttack : MonoBehaviour
{
    private int octopusDamage = 1;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerCombat>().TakeDamage(octopusDamage);
            DesactivarObjeto();

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
