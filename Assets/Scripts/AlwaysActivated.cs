using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AlwaysActivated : MonoBehaviour
{
    [SerializeField] private bool isFullscreen = true;
    public Toggle FullscreenToggle;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "Settings")
        FullscreenToggle.GetComponent<Toggle>();
    }
    void Update()
    {
        if (Input.GetAxisRaw("Fullscreen") > 0.001f) 
        {
            isFullscreen = !isFullscreen;
            Screen.fullScreen = isFullscreen;
            if (SceneManager.GetActiveScene().name == "Settings")
                FullscreenToggle.isOn = isFullscreen;
        }
    }
}
