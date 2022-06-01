using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextOnMouseover : MonoBehaviour
{
    public GameObject imageText;

    public void Start()
    {
        imageText.gameObject.SetActive(false);
        
    }

    public void OnMouseOver()
    {
        imageText.gameObject.SetActive(true);
        Debug.Log("Mouse is Over Object");
    }

    public void OnMouseExit()
    {
        imageText.gameObject.SetActive(false);
        Debug.Log("Mouse is no longer over object");
    }
}
