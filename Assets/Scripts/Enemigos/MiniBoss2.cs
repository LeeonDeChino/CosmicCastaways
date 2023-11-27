using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBoss2 : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject bulletPrefab;
    public Transform shootPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LiberarCastaway()
    {
        gameManager.LiberarCastaways(2);
    }
    public void Shoot()
    {
        Instantiate(bulletPrefab,shootPoint.position,Quaternion.identity);
    }
}
