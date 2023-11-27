using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    PlayerCombat player;
    public float bulletSpeed = 5f;
    Rigidbody2D bulletRB;
    [SerializeField] private int bulletDamage = 2;
    private SpriteRenderer sprite;
    private void OnEnable()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerCombat>();
        Vector2 moveDir = (player.transform.position - transform.position).normalized*bulletSpeed;
        bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);
        Invoke("DesactivarBala", 2f);

        float rot = Mathf.Atan2(-moveDir.y, -moveDir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }
    private void DesactivarBala()
    {
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.TakeDamage(bulletDamage);
            DesactivarBala();
        }
        if (other.CompareTag("Ground"))
        {
            DesactivarBala();
        }     
    }
}
