using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBoss2 : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject bulletPrefab;
    public Transform shootPoint;

    public void LiberarCastaway()
    {
        gameManager.LiberarCastaways(2);
    }
    public void Shoot()
    {
        Instantiate(bulletPrefab,shootPoint.position,Quaternion.identity);
    }
}
