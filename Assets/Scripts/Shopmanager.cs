using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shopmanager : MonoBehaviour
{
    public GameObject BuyErrorMessageText;
    public GameObject BuyAlreadyBoughtText;
    public GameObject BuyErrorMessage2Text;
    public GameObject BuyErrorMessage3Text;

    public float InvokeErrorMessageTime;
    public float InvokeAlreadyBoughtTime;

    public GameObject BuyTextGO;
    public GameObject isBoughtText;

    public bool isbuyable;
    public int isbought;
    public string currentObjectNameKey;
    public string previousObjectNameKey;

    public Button ownSelectButton;

    public string ownLevelPercentageKey;

    void Start()
    {
        BuyErrorMessageText.SetActive(false);
        BuyAlreadyBoughtText.SetActive(false);
        BuyErrorMessage2Text.SetActive(false);
        BuyErrorMessage3Text.SetActive(false);
        ownSelectButton = ownSelectButton.GetComponent<Button>();
    }

    private void Update()
    {
        isbought = PlayerPrefs.GetInt(currentObjectNameKey, 0);
        if (isbought == 1)
        {
            BuyTextGO.SetActive(false);
            isBoughtText.SetActive(true);
            ownSelectButton.interactable = true;
        }
        else
        {
            BuyTextGO.SetActive(true);
            isBoughtText.SetActive(false);
            ownSelectButton.interactable = false;
        }
        if (PlayerPrefs.GetInt(previousObjectNameKey, 0) == 1 || previousObjectNameKey == "firstObjectInList")
            isbuyable = true;
        else
            isbuyable = false;
    }
    public void BuyItem(int itemPrice)
    {
        if(PlayerPrefs.GetInt(ownLevelPercentageKey, 0) >= 100)
        {

            if (isbought == 0)
            {
                if (isbuyable == true)
                {
                    if (PlayerPrefs.GetInt("TotalCoinsKey", 0) >= itemPrice)
                    {
                        PlayerPrefs.SetInt("TotalCoinsKey", PlayerPrefs.GetInt("TotalCoinsKey") - itemPrice);
                        PlayerPrefs.SetInt(currentObjectNameKey, 1);
                    }
                    else
                    {
                        BuyErrorMessageText.SetActive(true);
                        Invoke("InvokeErrorMessage", InvokeErrorMessageTime);
                    }
                }
                else
                {
                    BuyErrorMessage2Text.SetActive(true);
                    Invoke("InvokeErrorMessage2", InvokeErrorMessageTime);
                }
            }
            else
            {
                BuyAlreadyBoughtText.SetActive(true);
                Invoke("InvokeAlreadyBoughtMessage", InvokeAlreadyBoughtTime);
            }
        }
        else
        {
            BuyErrorMessage3Text.SetActive(true);
            Invoke("InvokeErrorMessage3", InvokeErrorMessageTime);
        }

        

    }
    
    public void InvokeErrorMessage()
    {
        BuyErrorMessageText.SetActive(false);
    }

    public void InvokeAlreadyBoughtMessage()
    {
        BuyAlreadyBoughtText.SetActive(false);
    }

    public void InvokeErrorMessage2()
    {
        BuyErrorMessage2Text.SetActive(false);
    }

    public void InvokeErrorMessage3()
    {
        BuyErrorMessage3Text.SetActive(false);
    }
}
