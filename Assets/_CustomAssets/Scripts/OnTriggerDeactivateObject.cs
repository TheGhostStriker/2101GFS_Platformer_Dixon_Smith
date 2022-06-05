using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerDeactivateObject : MonoBehaviour
{
    public Transform lightObject;
    public Transform lightObject2;
    public Transform lightObject3;
    public Transform falseObject;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            falseObject.gameObject.SetActive(false);
            lightObject.gameObject.SetActive(true);
            lightObject2.gameObject.SetActive(true);
            lightObject3.gameObject.SetActive(true);
        }
    }
}
