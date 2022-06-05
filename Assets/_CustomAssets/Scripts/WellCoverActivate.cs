using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellCoverActivate : MonoBehaviour
{
    public Transform lightObject;
    public Transform lightObject2;
    public Transform lightObject3;
    public Transform triggerObject;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            triggerObject.gameObject.SetActive(true);
            lightObject.gameObject.SetActive(false);
            lightObject2.gameObject.SetActive(false);
            lightObject3.gameObject.SetActive(false);
        }
    }
        
}
