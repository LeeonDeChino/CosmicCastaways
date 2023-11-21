using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoltarItem : MonoBehaviour
{
    // cuando este objeto se destruya, se va a instanciar un item
    public GameObject item;

    private void OnDestroy()
    {
        // instanciar el item
        Instantiate(item, transform.position, transform.rotation);
    }

    // cuando el jugador colisione con el objeto, se destruye

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
