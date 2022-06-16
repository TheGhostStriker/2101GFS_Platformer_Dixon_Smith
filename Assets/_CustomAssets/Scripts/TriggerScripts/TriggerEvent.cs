using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent onTriggerEnter = new UnityEvent();
    public UnityEvent onTriggerExit = new UnityEvent();

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) onTriggerEnter.Invoke();
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) onTriggerExit.Invoke();
    }
}
