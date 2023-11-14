using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // crea una variable para la velocidad de la bala
    public float speed;
    // crea una variable para el rigidbody de la bala
    private Rigidbody2D rb;
    // crea una variable para el controlador de disparo
    private GameObject shootController;

    // Start is called before the first frame update

    void Start()
    {
        // asigna el rigidbody de la bala
        rb = GetComponent<Rigidbody2D>();
        // asigna el controlador de disparo
        shootController = GameObject.Find("ShootController");
        // asigna la velocidad de la bala
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame

    void Update()
    {
        // destruye la bala si sale de la pantalla
        if (transform.position.x > 10 || transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
