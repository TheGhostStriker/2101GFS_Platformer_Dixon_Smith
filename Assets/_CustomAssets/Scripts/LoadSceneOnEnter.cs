using UnityEngine;
using System.Collections;

public class LoadSceneOnEnter : MonoBehaviour 
{
	public Transform imageImage;
	public string scene;
	public string tag;


	// when something with a given tag enters my region, start the next level
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == tag)
		{
			Application.LoadLevel (scene);
			DontDestroyOnLoad(this.imageImage);
		}
	}
}
