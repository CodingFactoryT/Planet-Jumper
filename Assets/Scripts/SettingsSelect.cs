using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsSelect : MonoBehaviour
{
    public void Zurück()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
