using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour {

    [SerializeField]
    private Text pickUpText;

    private bool pickUpAllowed;
    private AudioSource audioTrigger;

	// Use this for initialization
	private void Start () {
        pickUpText.gameObject.SetActive(false);
        audioTrigger = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	private void Update () {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("2DCharacter"))
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
            audioTrigger.Play();

        }        
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("2DCharacter"))
        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
        
        Destroy(gameObject);
        
    }

}
