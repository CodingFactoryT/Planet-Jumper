using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonSelect : MonoBehaviour
{
    public void Zurück()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Levels()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void EndlessRunner()
    {
        SceneManager.LoadScene("EndlessRunnerSelect");
    }

    public void Minispiele()
    {
        SceneManager.LoadScene("MinispieleSelect");
    }

    public void NotDefined()
    {

    }
}
