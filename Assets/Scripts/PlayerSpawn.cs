using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    private GameObject Player;
    private GameObject GameOverPanel;
    private float DeadMarkerPosition = -26.0f;
    public static bool isGameOverPanelActive = false;
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        GameOverPanel = GameObject.FindGameObjectWithTag("GameOverPanel");
        StartCoroutine(Spawn());
    }

    private void Start()
    {
        Player.SetActive(false);
        GameOverPanel.SetActive(false);
    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(5.5F);

        Player.SetActive(true);
    }
    private void Update()
    {
        if (Player.transform.position.y < DeadMarkerPosition)
        {
            isGameOverPanelActive = true;
            GameOverPanel.SetActive(true);
            Player.SetActive(false);
        }
    }
}
