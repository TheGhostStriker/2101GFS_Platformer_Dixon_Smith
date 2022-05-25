using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnCollision : MonoBehaviour
{
    private AudioSource audioTrigger;
    public bool playOnlyOnce = false;
    // Start is called before the first frame update
    private void Start()
    {
        audioTrigger = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && audioTrigger.isPlaying == false)
        {
            audioTrigger.Play();
            if (playOnlyOnce) Destroy(gameObject, audioTrigger.clip.length);
        }
    }

    // Update is called once per frame
    
}
