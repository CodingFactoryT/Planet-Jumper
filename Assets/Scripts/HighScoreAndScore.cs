using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreAndScore : MonoBehaviour
{
    private float startpos;
    public GameObject Player;
    private int score;
    private int oldscore;
    private Text text;
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        text = GetComponent<Text>();
        startpos = Player.transform.position.x;
    }


    void Update()
    {
        
        score = (int) Player.transform.position.x;
        score -= (int) startpos;
        if (score < oldscore)
            score = oldscore;


        if (score < 0)
            score = 0;

        text.text = score.ToString() + " m";

        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        oldscore = score;
    }
}
