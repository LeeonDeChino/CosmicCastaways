using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctopusMovement : MonoBehaviour
{
    public float velocidadOctopus = 1f;
    public Transform limiteArriba;
    public Transform limiteAbajo;

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
            transform.Translate(Vector2.up * direccion * velocidadOctopus * Time.deltaTime);

            if (transform.position.y >= limiteArriba.position.y)
            {
                CambiarDireccion(-1);
            }
            else if (transform.position.y <= limiteAbajo.position.y)
            {
                CambiarDireccion(1);
            }
        }
          

    }

    private void CambiarDireccion(int nuevaDireccion)
    {
        direccion = nuevaDireccion;
    }
}
