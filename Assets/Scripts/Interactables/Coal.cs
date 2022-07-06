using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coal : MonoBehaviour
{
    public GameObject coalCollect;
    public GameObject coal;

    public float timer = 10;
    public float coalHealth = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            coalHealth -= 1;
            if (coalHealth <= 0)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                gameObject.GetComponent<CircleCollider2D>().enabled = false;
                gameObject.GetComponent<CapsuleCollider2D>().enabled = false;

                Instantiate(coalCollect, transform.position, Quaternion.identity);
            }
        }
    }
    private void Update()
    {
        if (timer >= 0 && coalHealth <= 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            coalHealth = 3;
            timer = 10;

            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<CircleCollider2D>().enabled = true;
            gameObject.GetComponent<CapsuleCollider2D>().enabled = true;
        }
    }
}
