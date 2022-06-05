using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerActivateObject : MonoBehaviour
{
    public Transform triggerObject;
    // Start is called before the first frame update
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            triggerObject.gameObject.SetActive(true);
        }
    }
}
