using System.Collections;
using UnityEngine;

public class TimedPlatform : MonoBehaviour
{
    public Sprite activeMaterial;

    public Sprite inactiveMaterial;

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
                GetComponent<SpriteRenderer>().sprite = activeMaterial;
                GetComponent<Collider2D>().enabled = active;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = inactiveMaterial;
                GetComponent<Collider2D>().enabled = active;
            }

            yield return new WaitForSeconds(blinkLength);
        }
    }
}
