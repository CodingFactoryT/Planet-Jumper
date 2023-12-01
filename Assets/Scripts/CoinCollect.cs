using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
   public static int CurrentCoins; //wenn {get; private set;} angehängt wird, heißt es, die Variable kann von überall gehplt werden, jedoch nur in der Klasse gesetzt werden
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Coin"))
        {
            Destroy(other.transform.parent.gameObject);
            CurrentCoins += 1;
            PlayerPrefs.SetInt("TotalCoinsKey", PlayerPrefs.GetInt("TotalCoinsKey") + 1);
        }
    
    }
}
