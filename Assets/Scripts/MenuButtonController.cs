using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject controlsPanel;
    public GameObject cheatPanel;

    public void OnClickControls()
    {
        mainPanel.SetActive(false);
        controlsPanel.SetActive(true);
    }
    public void OnClickMainPanel()
    {
        mainPanel.SetActive(true);
        controlsPanel.SetActive(false);
    }

    public void OnClickCheatPanel()
    {
        mainPanel.SetActive(false);
        cheatPanel.SetActive(true);
    }

    public void OnClickCheatMainPanel()
    {
        mainPanel.SetActive(true);
        cheatPanel.SetActive(false);
    }
}
