using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMovimiento;

    private Vector2 offset;
    private Material material;

    public Rigidbody2D jugador;
    public ArduinoInput input;
   

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;

    }
    void Update()
    {
        if(input.value == 1 || input.value == -1)
        {
            offset = (input.value * 0.1f) * velocidadMovimiento * Time.deltaTime;
            material.mainTextureOffset += offset;
        }
        
    }
}
