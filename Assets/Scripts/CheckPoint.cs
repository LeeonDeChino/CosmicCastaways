using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    // este sript es para que el jugador pueda guardar su progreso en el juego
    // crea una variable para el punto de control
    public Transform checkPoint;
    // crea una variable para el jugador
    public GameObject player;
    // crea una variable para el controlador de disparo
    public GameObject shootController;

    // Start is called before the first frame update
    void Start()
    {
        // asigna el jugador
        player = GameObject.Find("Player");
        // asigna el controlador de disparo
        shootController = GameObject.Find("ShootController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // quiero que cuando el jugador colisione con el punto de control, se guarde su progreso
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // si el jugador colisiona con el punto de control, se guarda su posicion y se destruye el punto de control

        if (collision.gameObject.tag == "Player")
        {
            // destruye el punto de control
            Destroy(gameObject);
            // mueestra en consola que se guardo el progreso
            Debug.Log("Guardado");
        }
    }
}
