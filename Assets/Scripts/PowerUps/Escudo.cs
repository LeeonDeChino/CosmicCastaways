using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escudo : MonoBehaviour
{
    // este es el script del escudo
    public float tiempoVida = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, tiempoVida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // si el jugador toca el escudo, se destruye y se activa el escudo si no es el jugador , no hace nada

        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            Debug.Log("Escudo activado");
        }
        else
        {
            gameObject.SetActive(true);
            Debug.Log("No es el jugador");
        }
    }
}
