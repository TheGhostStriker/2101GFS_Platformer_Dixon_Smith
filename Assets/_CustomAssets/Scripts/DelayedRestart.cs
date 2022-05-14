using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayedRestart : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 2f;


    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("OVER OVER");
            Restart();
        }
    }

    

    void Restart()
    {
        StartCoroutine("Restart2");
    }
    IEnumerator Restart2()
    {
        yield return new WaitForSeconds(restartDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
