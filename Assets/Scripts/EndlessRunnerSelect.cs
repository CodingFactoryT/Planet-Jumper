using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndlessRunnerSelect : MonoBehaviour
{
    public void Zurück()
    {
        SceneManager.LoadScene("Start");
    }

    public void EndlessRunner1()
    {
        SceneManager.LoadScene("EndlessRunnerMerkur");
        CoinCollect.CurrentCoins = 0;
    }

    public void EndlessRunner2()
    {
        SceneManager.LoadScene("EndlessRunnerVenus");
        CoinCollect.CurrentCoins = 0;
    }

    public void EndlessRunner3()
    {
        SceneManager.LoadScene("EndlessRunnerErde");
        CoinCollect.CurrentCoins = 0;
    }

    public void EndlessRunner4()
    {
        SceneManager.LoadScene("EndlessRunnerMars");
        CoinCollect.CurrentCoins = 0;
    }

    public void EndlessRunner5()
    {
        SceneManager.LoadScene("EndlessRunnerJupiter");
        CoinCollect.CurrentCoins = 0;
    }

    public void EndlessRunner6()
    {
        SceneManager.LoadScene("EndlessRunnerSaturn");
        CoinCollect.CurrentCoins = 0;
    }

    public void EndlessRunner7()
    {
        SceneManager.LoadScene("EndlessRunnerUranus");
        CoinCollect.CurrentCoins = 0;
    }

    public void EndlessRunner8()
    {
        SceneManager.LoadScene("EndlessRunnerNeptun");
        CoinCollect.CurrentCoins = 0;
    }

}
