using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{
    public float axisH;
    public float boton1;
    public float boton2;


    void Update()
    {
        axisH = Input.GetAxis("Horizontal");
        boton1 = Input.GetAxis("Fire1");
        boton2 = Input.GetAxis("Fire2");

    }
}
