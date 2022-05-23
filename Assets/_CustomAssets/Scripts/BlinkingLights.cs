using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingLights : MonoBehaviour
{
    public GameObject myLightObject;
    public bool isLightOn;
    // Start is called before the first frame update
    private void Start()
    {
        isLightOn = true;
    }

    // Update is called once per frame
    void Update()
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
        yield return new WaitForSeconds(3.075f);
        TurnLightsOff();
    }

    void LightsOff()
    {
        myLightObject.SetActive(false);
        isLightOn = false;
    }

    IEnumerator TurnLightsOn()
    {
        yield return new WaitForSeconds(3.075f);
        TurnLightsOn();
    }

    void LightsOn()
    {
        myLightObject.SetActive(true);
        isLightOn = true;
    }
}
