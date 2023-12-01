using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartWithButton : MonoBehaviour
{ 

    void Update()
    {
            if(Input.GetAxisRaw("Restart") > 0.001f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                CoinCollect.CurrentCoins = 0;
            }

    }
}
