using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainShopManager : MonoBehaviour
{
    public GameObject shopPanel;
    public GameObject characterPanel;
    public GameObject hatPanel;
    public GameObject flagPanel;
    public Image characterButtonImage;
    public Image hatButtonImage;
    public Image flagButtonImage;

    private Color32 selectedcolour;
    private Color32 whitecolour; 

    void Start()
    {
        characterButtonImage = characterButtonImage.GetComponent<Image>();
        hatButtonImage = hatButtonImage.GetComponent<Image>();
        shopPanel.SetActive(false);

        selectedcolour = new Color32(36, 117, 227, 255);
        whitecolour = new Color32(255, 255, 255, 255);
        characterButtonImage.color = selectedcolour;
    }

   
    void Update()
    {
        
    }

    public void OpenShop()
    {
        shopPanel.SetActive(true);
    }

    public void CloseShop()
    {
        shopPanel.SetActive(false);
    }

    public void OpenCharacterSelection()
    {
        hatPanel.SetActive(false);
        flagPanel.SetActive(false);
        characterPanel.SetActive(true);
        hatButtonImage.color = whitecolour;
        flagButtonImage.color = whitecolour;
        characterButtonImage.color = selectedcolour;
    }

    public void OpenHatSelection()
    {
        characterPanel.SetActive(false);
        flagPanel.SetActive(false);
        hatPanel.SetActive(true);
        characterButtonImage.color = whitecolour;
        flagButtonImage.color = whitecolour;
        hatButtonImage.color = selectedcolour;
    }

    public void OpenFlagSelection()
    {
        hatPanel.SetActive(false);
        characterPanel.SetActive(false);
        flagPanel.SetActive(true);
        hatButtonImage.color = whitecolour;
        characterButtonImage.color = whitecolour;
        flagButtonImage.color = selectedcolour;
    }
}
