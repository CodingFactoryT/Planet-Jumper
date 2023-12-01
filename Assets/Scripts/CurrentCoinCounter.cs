using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentCoinCounter : MonoBehaviour
{
    private Text counterText;
    


    void Start()
    {
        counterText = GetComponent<Text>();
        UpdateText();
        
    }

    
    void LateUpdate()
    {
        UpdateText();
    }
    private void UpdateText()
    {
        counterText.text = CoinCollect.CurrentCoins.ToString();  
    }
}
