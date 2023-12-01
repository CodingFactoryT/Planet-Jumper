using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalCoinCounter : MonoBehaviour
{
    private Text counterText;
    void Start()
    {
        counterText = GetComponent<Text>();
        UpdateText();
    }

    
    void Update()
    {
        UpdateText();
    }

    private void UpdateText()
    {
        counterText.text = PlayerPrefs.GetInt("TotalCoinsKey", 0).ToString();
    }
}
