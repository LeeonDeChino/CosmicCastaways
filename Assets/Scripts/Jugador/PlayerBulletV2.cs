using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerBulletV2 : MonoBehaviour
{
    [Range(1, 10)]
    public float bulletSpeed;

    public int damage = 1;

    private Action<PlayerBulletV2> desactivarAccion;

    public float tiempoDeVida;

    PlayerLookDirection playerLookDirection;

    Vector2 direction;

    private bool isLookingLeft;

    private void OnEnable()
    {
        StartCoroutine(DesactivarTiempo());
        playerLookDirection = FindObjectOfType<PlayerLookDirection>();
        SetBulletDirection();
    }
    private void SetBulletDirection()
    {
        isLookingLeft = !playerLookDirection.isLookingRight;

        if (isLookingLeft)
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.right;
        }
    }
    void Update()
    {
        transform.Translate(bulletSpeed * Time.deltaTime * direction);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyHealthManager>().TakeDamage(damage);
            desactivarAccion(this);
        }
        if (other.CompareTag("Ground"))
        {
            desactivarAccion(this);
        }
        if (other.CompareTag("MiniBoss"))
        {
            other.GetComponent<MinibossHealthManager>().TakeDamage(damage);
            desactivarAccion(this);
        }
    }

    private IEnumerator DesactivarTiempo()
    {
        yield return new WaitForSeconds(tiempoDeVida);
        desactivarAccion(this);
    }

    public void DesactivarBala(Action<PlayerBulletV2> desactivarAccionParametro)
    {
        desactivarAccion = desactivarAccionParametro;
    }
}
