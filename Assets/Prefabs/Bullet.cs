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
        //rb.velocity = transform.right * speed;
    }

    // Update is called once per frame

    void Update()
    {
        // destruye la bala depsues de 2 segundos
        Destroy(gameObject, 2f);
        
    }

    // quiero que cuando la bala colisione con un enemigo, se destruya

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // si la bala colisiona con un enemigo, se destruye y le hace daño al enemigo
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
