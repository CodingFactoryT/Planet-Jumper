using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour
{
    public GameObject PausePanel = null;

    void Awake()
    {
        PausePanel = GameObject.FindGameObjectWithTag("PausePanel");
        PausePanel.SetActive(false);
        Debug.Log("Start init");
        PlayerSpawn.isGameOverPanelActive = false;
    }

    public void Pause()
    {
        if (PlayerSpawn.isGameOverPanelActive == false)
        {
            PausePanel.SetActive(true);
            Debug.Log("Paused");
            Time.timeScale = 0f;
        }
    }
}
