using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DestroyObjectByName : MonoBehaviour
{
    public GameObject DumbwaiterWall;
    public GameObject UITrigger;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(GameObject.Find("DumbwaiterWall"));
            Destroy(GameObject.Find("UITrigger"));
        }
        
    }
}
