using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectPercentage : MonoBehaviour
{
    public string ownButtonPercentageKey;
    public Text ownPercentageText;
    void Awake()
    {
        ownPercentageText = GetComponent<Text>();
        ownPercentageText.text = PlayerPrefs.GetInt(ownButtonPercentageKey, 0).ToString() + "% Abgeschlossen\n";
    }


}
