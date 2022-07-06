using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public string myScene;
    public void OnClick()
    {
        SceneManager.LoadScene(myScene);
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }
}
