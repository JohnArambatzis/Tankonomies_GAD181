using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public bool isPaused;

    public GameObject pausePanel;

    public GameObject shopPanel1;

    void Start()
    {
        Time.timeScale = 1;
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && !isPaused)
        {
            pausePanel.SetActive(true);
            TogglePause();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.tag == "Shop 1")
        {
            if (Input.GetKey(KeyCode.E) && !isPaused)
            {
                shopPanel1.SetActive(true);
                TogglePause();
            }
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 0;
            //Cursor.lockState = CursorLockMode.None;
            //Cursor.visible = true;
        }
        else
        {
            Time.timeScale = 1;
            //Cursor.lockState = CursorLockMode.Locked;
            //Cursor.visible = false;

            pausePanel.SetActive(false);
            shopPanel1.SetActive(false);
        }
    }
}
