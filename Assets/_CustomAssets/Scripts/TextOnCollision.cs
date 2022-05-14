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
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            myText.enabled = false;
            myImage.enabled = false;
            
        }
    }
    
}
