using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMovimiento;

    private Vector2 offset;
    private Material material;
    public ControllerInput control;
    public Rigidbody2D jugador;
    public ArduinoInput input;
    float val;
   

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }
    void Update()
    {
        val = control.axisH;
        if(input.joystickValue == -1 || control.axisH <= -0.1f)
        {
            offset = (-1f * 0.1f) * velocidadMovimiento * Time.deltaTime;
            material.mainTextureOffset += offset;
        }
        else if(input.joystickValue == 1 || control.axisH >= 0.1f)
        {
            offset = (1 * 0.1f) * velocidadMovimiento * Time.deltaTime;
            material.mainTextureOffset += offset;
        }
        
    }
}
