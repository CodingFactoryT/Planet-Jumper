using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdminSetScript : MonoBehaviour
{
    void Awake()
    {
        /* 
            PlayerPrefs.SetInt("HighScore", 0);

            PlayerPrefs.SetInt("TotalCoinsKey", 0);
            PlayerPrefs.SetInt("isMerkurBoughtKey", 0);
            PlayerPrefs.SetInt("isVenusBoughtKey", 0);
            PlayerPrefs.SetInt("isErdeBoughtKey", 0);
            PlayerPrefs.SetInt("isMarsBoughtKey", 0);
            PlayerPrefs.SetInt("isJupiterBoughtKey", 0);
            PlayerPrefs.SetInt("isSaturnBoughtKey", 0);
            PlayerPrefs.SetInt("isUranusBoughtKey", 0);
            PlayerPrefs.SetInt("isNeptunBoughtKey", 0);
            
        PlayerPrefs.SetInt("LevelPercentageErde", 0);
        PlayerPrefs.SetInt("LevelPercentageJupiter", 0);
        PlayerPrefs.SetInt("LevelPercentageMars", 0);
        PlayerPrefs.SetInt("LevelPercentageMerkur", 0);
        PlayerPrefs.SetInt("LevelPercentageNeptun", 0);
        PlayerPrefs.SetInt("LevelPercentageSaturn", 0);
        PlayerPrefs.SetInt("LevelPercentageUranus", 0);
        PlayerPrefs.SetInt("LevelPercentageVenus", 0);
        */


    }

    public void hundretpercentforeveryLevel()
        {
        PlayerPrefs.SetInt("LevelPercentageErde", 100);
        PlayerPrefs.SetInt("LevelPercentageJupiter", 100);
        PlayerPrefs.SetInt("LevelPercentageMars", 100);
        PlayerPrefs.SetInt("LevelPercentageMerkur", 100);
        PlayerPrefs.SetInt("LevelPercentageNeptun", 100);
        PlayerPrefs.SetInt("LevelPercentageSaturn", 100);
        PlayerPrefs.SetInt("LevelPercentageUranus", 100);
        PlayerPrefs.SetInt("LevelPercentageVenus", 100);
        }

        public void Get1000Coins()
        {
        PlayerPrefs.SetInt("TotalCoinsKey", PlayerPrefs.GetInt("TotalCoinsKey", 0) + 1000);
        }


}
