using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject controlsPanel;

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
}
