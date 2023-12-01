using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelPercentageManager : MonoBehaviour
{
    private float startpos;
    public GameObject Player;
    private int percentage;
    private int oldpercentage;
    private Text text;
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        text = GetComponent<Text>();
        startpos = Player.transform.position.x;
    }


    void Update()
    {

        percentage = (int)Player.transform.position.x;
        percentage -= (int)startpos;
        percentage /= 5; 
        if (percentage < oldpercentage)
            percentage = oldpercentage;


        if (percentage < 0)
            percentage = 0;

        text.text = percentage.ToString() + " %";

        switch(SceneManager.GetActiveScene().name)
        {
            case "LevelErde":
                if (percentage > PlayerPrefs.GetInt("LevelPercentageErde", 0))
                {
                    PlayerPrefs.SetInt("LevelPercentageErde", percentage);
                }
                break;

            case "LevelJupiter":
                if (percentage > PlayerPrefs.GetInt("LevelPercentageJupiter", 0))
                {
                    PlayerPrefs.SetInt("LevelPercentageJupiter", percentage);
                }
                break;

            case "LevelMars":
                if (percentage > PlayerPrefs.GetInt("LevelPercentageMars", 0))
                {
                    PlayerPrefs.SetInt("LevelPercentageMars", percentage);
                }
                break;

            case "LevelMerkur":
                if (percentage > PlayerPrefs.GetInt("LevelPercentageMerkur", 0))
                {
                    PlayerPrefs.SetInt("LevelPercentageMerkur", percentage);
                }
                break;

            case "LevelNeptun":
                if (percentage > PlayerPrefs.GetInt("LevelPercentageNeptun", 0))
                {
                    PlayerPrefs.SetInt("LevelPercentageNeptun", percentage);
                }
                break;

            case "LevelSaturn":
                if (percentage > PlayerPrefs.GetInt("LevelPercentageSaturn", 0))
                {
                    PlayerPrefs.SetInt("LevelPercentageSaturn", percentage);
                }
                break;

            case "LevelUranus":
                if (percentage > PlayerPrefs.GetInt("LevelPercentageUranus", 0))
                {
                    PlayerPrefs.SetInt("LevelPercentageUranus", percentage);
                }
                break;

            case "LevelVenus":
                if (percentage > PlayerPrefs.GetInt("LevelPercentageVenus", 0))
                {
                    PlayerPrefs.SetInt("LevelPercentageVenus", percentage);
                }
                break;
        }

        oldpercentage = percentage;
    }
}
