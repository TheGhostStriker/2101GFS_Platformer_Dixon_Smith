using System.Collections;
using UnityEngine;

public class TimedPlatform : MonoBehaviour
{
    public Material activeMaterial;

    public Material inactiveMaterial;

    public float blinkOffset;

    public float blinkLength;

    public bool active; 

    private void Start()
    {
        StartCoroutine("Blink");
    }

    IEnumerator Blink()
    {
        yield return new WaitForSeconds(blinkOffset);

        while (true)
        {
            active = !active;

            if (active)
            {
                GetComponent<MeshRenderer>().material = activeMaterial;
                GetComponent<Collider2D>().enabled = active;
            }
            else
            {
                GetComponent<MeshRenderer>().material = inactiveMaterial;
                GetComponent<Collider2D>().enabled = active;
            }

            yield return new WaitForSeconds(blinkLength);
        }
    }
}
