using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    public int speed;



    void LateUpdate()
    {
        transform.Rotate(Vector2.up * speed * Time.deltaTime);
    }
}
