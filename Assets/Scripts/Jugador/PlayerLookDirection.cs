using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookDirection : MonoBehaviour
{
    public bool isLookingRight = true;
    private int direccion = 1;

    public void LookDirection(int val)
    {
        if (val < 0)
        {
            isLookingRight = false;
            CambiarDireccion(-1);
        }
        else
        {
            isLookingRight = true;
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
