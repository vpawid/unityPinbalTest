using UnityEngine;
using System.Collections;

public class roofBreak : MonoBehaviour {

int death = 3;

public GameObject remains;
	void OnCollisionEnter(Collision col)
	{
		if(col.rigidbody)
		{
			death -= 1;
			audio.Play();
		}
	
	}
	// Update is called once per frame
	void Update () {
		if(death == 0)
		{
			
			
			Instantiate(remains, transform.position, transform.rotation);
			GameObject.Destroy(gameObject);
			
		}

	}
}
