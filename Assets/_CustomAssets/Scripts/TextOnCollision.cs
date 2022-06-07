using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOnCollision : MonoBehaviour
{
    public Image myImage;
    public Text myText;

    void start()
    {
        myText.enabled = false;
        myImage.enabled = false;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            myText.enabled = true;
            myImage.enabled = true;
            // Put Destroy here instead and remove TriggerExit
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            myText.enabled = false;
            myImage.enabled = false;
            Destroy(this.gameObject, 5f);
            
        }
    }
    
}
