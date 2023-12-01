using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessPlatformSpawner : MonoBehaviour
{
    private const float PlayerDistanceSpawnPart = 20;
    [SerializeField] private Transform Part_Start;
    [SerializeField] private List<Transform> PartList;
    [SerializeField] private Transform player;

    private Vector2 lastEndPosition;

    public GameObject pausePanel;
    public GameObject GameOverPanel;
    private void Awake()
    {
        GameOverPanel = GameObject.FindGameObjectWithTag("GameOverPanel");
        lastEndPosition = Part_Start.Find("EndPosition").position;
        int startingSpawnParts = 2;
        for (int i = 0; i < startingSpawnParts; i++)
        {
            SpawnPart();
        }
        player = GameObject.FindWithTag("Player").transform;
    }
    private void Update()
    {
        if(GameOverPanel.activeInHierarchy == false)
        {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        }
        }
        if (Vector2.Distance(player.position, lastEndPosition) < PlayerDistanceSpawnPart)
        {
            SpawnPart();
        }
    }
    private void SpawnPart()
    {
        Transform chosenPart = PartList[Random.Range(0, PartList.Count)];
        Transform lastPartTransform = SpawnPart(chosenPart, lastEndPosition);
        lastEndPosition = lastPartTransform.Find("EndPosition").position;
    }
    private Transform SpawnPart(Transform Part, Vector2 spawnposition)
    {
        Transform PartTransform = Instantiate(Part, spawnposition, Quaternion.identity);
        return PartTransform;
    }
}
