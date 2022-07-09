using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crystal : MonoBehaviour
{
    public GameObject crystalCollect;
    public GameObject crystal;
    public GameObject crystalCanvas;

    public Text crystalHealthText;
    public float timer = 20;
    public float crystalHealth = 8;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            crystalHealth -= 1;
            crystalHealthText.text = crystalHealth.ToString();

            if (crystalHealth <= 0)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                gameObject.GetComponent<CircleCollider2D>().enabled = false;
                gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
                crystalCanvas.GetComponent<Canvas>().enabled = false;

                Instantiate(crystalCollect, transform.position, Quaternion.identity);
            }
        }
    }
    private void Update()
    {
        if (timer >= 0 && crystalHealth <= 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            crystalHealth = 8;
            timer = 20;
            crystalHealthText.text = crystalHealth.ToString();

            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<CircleCollider2D>().enabled = true;
            gameObject.GetComponent<CapsuleCollider2D>().enabled = true;
            crystalCanvas.GetComponent<Canvas>().enabled = true;
        }
    }
}
