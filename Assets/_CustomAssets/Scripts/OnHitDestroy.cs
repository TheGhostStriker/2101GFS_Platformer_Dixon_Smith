using UnityEngine;
using System.Collections;

public class OnHitDestroy : MonoBehaviour 
{
	public void OnHit()
	{
		Destroy(gameObject, 0.09f);  // , 0.6f);	// ensure we get points, etc before this is destroyed
	}
}
