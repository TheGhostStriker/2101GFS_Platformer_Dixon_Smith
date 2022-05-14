using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTimer : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
       //Destroy(gameObject, 2f); // Destroy game object after 2 seconds

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject, 2f); // Destroy gameobject after 1 second of player being on it!
        }
    }
}
