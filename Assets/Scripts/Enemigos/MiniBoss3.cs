using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBoss3 : MonoBehaviour
{
    public GameManager gameManager;

    public Transform player;
    public float range;
    public float shootRange;

    public GameObject bulletPrefab;
    public Transform shootPoint;

    public void Shoot()
    {
        Instantiate(bulletPrefab,shootPoint.position,Quaternion.identity);  
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position,range);
        Gizmos.DrawWireSphere(transform.position, shootRange);
    }
    public void LiberarCastaway()
    {
        gameManager.LiberarCastaways(3);
    }
}
