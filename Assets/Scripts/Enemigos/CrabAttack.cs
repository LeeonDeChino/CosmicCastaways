using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabAttack : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //daño jugador
            //other.GetComponent<PlayerBehaviour>().TakeDamage();
            DesactivarObjeto();

        }

        if (other.CompareTag("Bullet"))
        {
            //Daño crab
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
