using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTimer : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
       

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject, 1.5f); // Destroy gameobject after 1 and a half seconds of player being on it!
        }
    }
}
