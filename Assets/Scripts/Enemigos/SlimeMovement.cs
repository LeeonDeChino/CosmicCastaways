using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMovement : MonoBehaviour
{
    public float velocidadSlime = 3f;
    public Transform limiteIzquierdo;
    public Transform limiteDerecho;

    private int direccion = 1;

    private void Update()
    {

        transform.Translate(Vector2.right * direccion * velocidadSlime * Time.deltaTime);

        if (transform.position.x >= limiteDerecho.position.x)
        {
            CambiarDireccion(-1);
        }
        else if (transform.position.x <= limiteIzquierdo.position.x)
        {
            CambiarDireccion(1);
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
