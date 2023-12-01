using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectButton : MonoBehaviour
{
    public void Zurück()
    {
        SceneManager.LoadScene("Start");
    }

    public void Level1()
    {
        SceneManager.LoadScene("LevelMerkur");
        CoinCollect.CurrentCoins = 0;
    }

    public void Level2()
    {
        SceneManager.LoadScene("LevelVenus");
        CoinCollect.CurrentCoins = 0;
    }

    public void Level3()
    {
        SceneManager.LoadScene("LevelErde");
        CoinCollect.CurrentCoins = 0;
    }

    public void Level4()
    {
        SceneManager.LoadScene("LevelMars");
        CoinCollect.CurrentCoins = 0;
    }

    public void Level5()
    {
        SceneManager.LoadScene("LevelJupiter");
        CoinCollect.CurrentCoins = 0;
    }

    public void Level6()
    {
        SceneManager.LoadScene("LevelSaturn");
        CoinCollect.CurrentCoins = 0;
    }

    public void Level7()
    {
        SceneManager.LoadScene("LevelUranus");
        CoinCollect.CurrentCoins = 0;
    }

    public void Level8()
    {
        SceneManager.LoadScene("LevelNeptun");
        CoinCollect.CurrentCoins = 0;
    }
}
