using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnRandomTimer : MonoBehaviour
{
    public float timerMin;
    public float timerMax;

    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(timerMin, timerMax);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            return;
        }
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject, 1.5f);
        }
        
    }
}
