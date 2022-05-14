using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    public float speed; // Platforms speed
    public int startingPoint; // starting point of platforms
    public Transform[] points; // array of where the platform needs to move

    private int i; // Index of the array
    // Start is called before the first frame update
    void Start()
    {

        transform.position = points[startingPoint].position; // Setting the start position of the platform
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Vector2.Distance(transform.position, points[i].position) < 0.0002f)
        {
            i++;
            if (i == points.Length)
            {
                i = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.SetParent(gameObject.transform, true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.gameObject.transform.parent = null;
    }
}
