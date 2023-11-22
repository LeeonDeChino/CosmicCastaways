using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class DisparoV2 : MonoBehaviour
{
    public Transform shootController;

    public PlayerBulletV2 bulletPrefab;
    [SerializeField] private float cooldown;
    private float tiempoSiguienteDisparo = 0;

    public ArduinoInput arduinoInput;
    private int input;
    

    private ObjectPool<PlayerBulletV2> bulletPool;

    private void Start()
    {
        bulletPool = new ObjectPool<PlayerBulletV2>(() =>
        {
            PlayerBulletV2 bullet = Instantiate(bulletPrefab, shootController.position, Quaternion.identity);
            bullet.DesactivarBala(DesactivarBalaPool);
            return bullet;
        }, bullet =>
        {
            bullet.transform.position = shootController.position;
            bullet.transform.rotation = Quaternion.identity;
            bullet.gameObject.SetActive(true);
        }, bullet =>
        {
            bullet.gameObject.SetActive(false);
        }, bullet =>
        {
            Destroy(bullet.gameObject);
        }, true, 10, 25);
    }

    private void Update()
    {
        
        if (tiempoSiguienteDisparo > 0)
        {
            tiempoSiguienteDisparo -= Time.deltaTime;
        }

        //Detecta cuando se presiona el botón.
        input = arduinoInput.value;
        if (input == 3)
        {
            if (tiempoSiguienteDisparo <= 0)
            {
                Disparar();
                tiempoSiguienteDisparo = cooldown;
            }
        }

    }
    public void Disparar()
    {
        bulletPool.Get();
        //sonido disparo
    }

    private void DesactivarBalaPool(PlayerBulletV2 bullet)
    {
        if (bullet != null && bullet.gameObject.activeSelf)
        {
            bulletPool.Release(bullet);
        }
    }
}
