using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabMovement : MonoBehaviour
{
    public float velocidadCrab = 1.5f;
    public Transform limiteIzquierdo;
    public Transform limiteDerecho;

    private int direccion = 1;
    EnemyHealthManager enemyScript;
    private bool isDead = false;

    private void Start()
    {
        enemyScript = GetComponent<EnemyHealthManager>();
    }
    private void Update()
    {
        isDead = enemyScript.isDead;

        if (!isDead)
        {
            transform.Translate(Vector2.right * direccion * velocidadCrab * Time.deltaTime);

            if (transform.position.x >= limiteDerecho.position.x)
            {
                CambiarDireccion(-1);
            }
            else if (transform.position.x <= limiteIzquierdo.position.x)
            {
                CambiarDireccion(1);
            }
        }
            

    }

    private void CambiarDireccion(int nuevaDireccion)
    {
        direccion = nuevaDireccion;
        Vector3 escala = transform.localScale;

        escala.x *= -1;
        transform.localScale = escala;
    }

}
