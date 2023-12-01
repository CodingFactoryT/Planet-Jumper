using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStickToMovPlatform : MonoBehaviour
{
    private GameObject Player;
    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
     private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = transform;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = null;
        }
    }
}
