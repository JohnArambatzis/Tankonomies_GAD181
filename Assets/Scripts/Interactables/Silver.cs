using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Silver : MonoBehaviour
{
    public GameObject silverCollect;
    public GameObject silver;
    public GameObject silverCanvas;

    public Text silverHealthText;
    public float timer = 10;
    public float silverHealth = 4;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            silverHealth -= 1;
            silverHealthText.text = silverHealth.ToString();

            if (silverHealth <= 0)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                gameObject.GetComponent<CircleCollider2D>().enabled = false;
                gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
                silverCanvas.GetComponent<Canvas>().enabled = false;

                Instantiate(silverCollect, transform.position, Quaternion.identity);
            }
        }
    }
    private void Update()
    {
        if (timer >= 0 && silverHealth <= 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            silverHealth = 4;
            timer = 12;
            silverHealthText.text = silverHealth.ToString();

            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<CircleCollider2D>().enabled = true;
            gameObject.GetComponent<CapsuleCollider2D>().enabled = true;
            silverCanvas.GetComponent<Canvas>().enabled = false;
        }
    }
}
