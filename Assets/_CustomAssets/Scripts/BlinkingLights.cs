4using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingLights : MonoBehaviour
{
    public GameObject myLightObject;
    public bool isLightOn;

    private void Start()
    {
        isLightOn = true;
    }

    private void Update()
    {
        if (isLightOn == true)
        {
            StartCoroutine(TurnLightsOff());
        
        }
        if (isLightOn == false)
        {
            StartCoroutine(TurnLightsOn());
        }
    }

    IEnumerator TurnLightsOff()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 5.9f));
        LightsOff();
    }

    void LightsOff()
    {
        myLightObject.SetActive(false);
        isLightOn = false;
    }

    IEnumerator TurnLightsOn()
    {
        yield return new WaitForSeconds(Random.Range(6.0f, 15f));
        LightsOn();
    }

    void LightsOn()
    {
        myLightObject.SetActive(true);
        isLightOn = true;
    }
}
