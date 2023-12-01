using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FallingPlatforms : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float fallDelay;
    public float destroyDelay;
    void Start()
    {
         rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.CompareTag("Player"))
        {
            Invoke("Falling", destroyDelay);
            Destroy(gameObject, fallDelay);
        }

    }
        void Falling()
        {
            rigidbody.isKinematic = false;
        }
}
