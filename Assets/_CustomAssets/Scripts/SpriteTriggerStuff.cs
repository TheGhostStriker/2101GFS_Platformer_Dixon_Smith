using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteTriggerStuff : MonoBehaviour
{
    public Transform soulObject;
    public Transform lightObject;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Soul"))
        {
            lightObject.gameObject.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}
