using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsSelect : MonoBehaviour
{
    public void Zur�ck()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
