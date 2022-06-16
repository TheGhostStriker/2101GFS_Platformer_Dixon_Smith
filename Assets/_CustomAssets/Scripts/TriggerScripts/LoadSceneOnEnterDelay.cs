using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneOnEnterDelay : MonoBehaviour
{
    public int sceneNumber;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            StartCoroutine(SceneLoadWithDelay(sceneNumber, 3));

        }
    }

    IEnumerator SceneLoadWithDelay(int sceneNum, int numSeconds)
    {
        yield return new WaitForSeconds(numSeconds);

        SceneManager.LoadScene(sceneNum);
    }
}
