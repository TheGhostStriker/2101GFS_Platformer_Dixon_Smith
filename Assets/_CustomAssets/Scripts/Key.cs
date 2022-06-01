using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour {

    [SerializeField]
    private Text pickUpText;

    public AudioSource pickupTrigger;
    public Transform inventoryImage;

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
            // audioTrigger.Play();

        }        
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("2DCharacter"))
        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
            // audioTrigger.Play();
        }
    }

    private void PickUp()
    {
        // Debug.Log("Object deleting, sound playing");
        inventoryImage.gameObject.SetActive(true);
        pickupTrigger.Play();
        gameObject.SetActive(false);
       
    }
    
}
