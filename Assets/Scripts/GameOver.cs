using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public void Neustart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        CoinCollect.CurrentCoins = 0;
    }

    public void ZurückZumHauptmenu()
    {
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
