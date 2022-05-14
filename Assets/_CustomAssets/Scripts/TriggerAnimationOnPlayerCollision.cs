using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimationOnPlayerCollision : MonoBehaviour
{
    [SerializeField] public Animator linkedAnimation;


    private void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            linkedAnimation.SetBool("Trigger" , true);
        }
    }
}
