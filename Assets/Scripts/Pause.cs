using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public void Weiter()
    {
        Time.timeScale = 1f;
        GameObject.FindGameObjectWithTag("PausePanel").SetActive(false);
    }
    public void Neustart()
    {
        GameObject.FindGameObjectWithTag("PausePanel").SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
        CoinCollect.CurrentCoins = 0;
    }

    public void ZurückZumHauptmenu()
    {
        Time.timeScale = 1f;
        GameObject.FindGameObjectWithTag("PausePanel").SetActive(false);
       if (SceneManager.GetActiveScene().name == "EndlessRunnerMerkur" ||
           SceneManager.GetActiveScene().name == "EndlessRunnerVenus" ||
           SceneManager.GetActiveScene().name == "EndlessRunnerErde" ||
           SceneManager.GetActiveScene().name == "EndlessRunnerMars" ||
           SceneManager.GetActiveScene().name == "EndlessRunnerJupiter" ||
           SceneManager.GetActiveScene().name == "EndlessRunnerSaturn" ||
           SceneManager.GetActiveScene().name == "EndlessRunnerUranus" ||
           SceneManager.GetActiveScene().name == "EndlessRunnerNeptun")
            SceneManager.LoadScene("EndlessRunnerSelect");

        if (SceneManager.GetActiveScene().name == "LevelMerkur" ||
            SceneManager.GetActiveScene().name == "LevelVenus" ||
            SceneManager.GetActiveScene().name == "LevelErde" ||
            SceneManager.GetActiveScene().name == "LevelMars" ||
            SceneManager.GetActiveScene().name == "LevelJupiter" ||
            SceneManager.GetActiveScene().name == "LevelSaturn" ||
            SceneManager.GetActiveScene().name == "LevelUranus" ||
            SceneManager.GetActiveScene().name == "LevelNeptun")
            SceneManager.LoadScene("LevelSelect");
    }
}
