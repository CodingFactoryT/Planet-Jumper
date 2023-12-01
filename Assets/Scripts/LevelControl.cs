using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControl : MonoBehaviour
{
    public GameObject LevelFinishedPanel;
    private GameObject Player;
    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        LevelFinishedPanel = GameObject.FindGameObjectWithTag("LevelFinishedPanel");
    }

    private void Start()
    {
        LevelFinishedPanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Player.SetActive(false);
        LevelFinishedPanel.SetActive(true);
    }
}
