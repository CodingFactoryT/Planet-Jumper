using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonSelect : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Start");
    }

    public void Einstellungen()
    {
        SceneManager.LoadScene("Settings");
    }

    public void SpielBeenden()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
            #else
        Application.Quit();
#endif
    }

}
