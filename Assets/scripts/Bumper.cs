using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {

	public float force = 100.0f;
	public float forceRadius = 1.0f;
	public int howMuchScore;
	void OnCollisionEnter(Collision collision)
	{
		if(collision.rigidbody)
		{
			audio.Play ();
			texteditor.score+= howMuchScore;
	
		}
		foreach(Collider col in Physics.OverlapSphere(transform.position, forceRadius))
		{
			if(col.rigidbody)
			{
				col.rigidbody.AddExplosionForce(force,transform.position,forceRadius);
				
			}
		}
	}
}
