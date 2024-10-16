using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinMenu : MonoBehaviour

{
    public void onRetry()
    {
        SceneManager.LoadScene(1);
    }

    public void onQuit()
    {
        Application.Quit();
    }
}
