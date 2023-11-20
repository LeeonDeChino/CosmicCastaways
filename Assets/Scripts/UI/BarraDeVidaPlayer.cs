using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVidaPlayer : MonoBehaviour
{
    private Slider slider;
    public Image relleno;

    public void InicializarBarraDeVida(int vida)
    {
        slider = GetComponent<Slider>();
        CambiarVidaMax(vida);
        CambiarVidaActual(vida);
        CambiarSpriteVida(vida);
    }
    public void CambiarVidaMax(int vidaMax)
    {
        slider.maxValue = vidaMax;
    }

    public void CambiarVidaActual(int vida)
    {
        slider.value = vida;
        CambiarSpriteVida(vida);
    }

    void CambiarSpriteVida(int vida)
    {
        if (vida >= 4)
        {
            relleno.color = relleno.color;
        }
        else if (vida >= 2)
        {
            relleno.color = Color.yellow;
        }
        else
        {
            relleno.color = Color.red;
        }
    }
}
