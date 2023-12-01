using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetHighscore : MonoBehaviour
{
    private Text text;
    void Start()
    {
        text = GetComponent<Text>();
        text.text = "Highscore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}
