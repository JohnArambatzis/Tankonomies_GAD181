using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;

    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    public float timer = 1f;

    public bool shootSpeed;

    void Update()
    {
        if (timer >= 0f)
        {
            timer -= Time.deltaTime;
        }
        if (Input.GetButtonDown("Fire1") && timer <= 0f)
        {
            if (shootSpeed == false)
            {
                Shoot();
                timer = 1f;
            }
            if (shootSpeed == true)
            {
                Shoot();
                timer = 0.6f;
            }
        }
    }

    void Shoot()
    {
        if (Time.timeScale == 1)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        }
        
    }
}
