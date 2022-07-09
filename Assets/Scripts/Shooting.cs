using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;

    public GameObject bulletPrefab;
    public GameObject happyBulletPrefab;

    public float bulletForce = 20f;
    public float timer = 1f;

    public bool shootSpeed;
    public bool bulletCosmetic;

    void Update()
    {
        if (timer >= 0f)
        {
            timer -= Time.deltaTime; // Make timer count down
        }
        if (Input.GetButton("Fire1") && timer <= 0f) // If LeftClick & timer is 0 then you can fire (changed it to work with holdling down left click)
        {
            if (shootSpeed == false) // If the bool shootSpeed is false the do this if statement
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
        if (Time.timeScale == 1) // This makes it so you can only shoot if the in game time is not paused when you try to fire, so you dont shoot while in the shop or paused
        {
            if (bulletCosmetic == false)
            {
                GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            }
            if (bulletCosmetic == true)
            {
                GameObject bullet = Instantiate(happyBulletPrefab, firePoint.position, firePoint.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            }
        }
        
    }
}
