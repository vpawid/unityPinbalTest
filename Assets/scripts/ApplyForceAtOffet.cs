using UnityEngine;
using System.Collections;

public class ApplyForceAtOffet : MonoBehaviour {

	public float force = 100.0f;
	public Vector3 forceDirection = Vector3.up;
	public string buttonName = "Fire1";
	public Vector3 offset;
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetButton(buttonName))
		{
			rigidbody.AddForceAtPosition(forceDirection.normalized*force,transform.position+offset);
		}
		else
		{
			rigidbody.AddForceAtPosition(forceDirection.normalized*-force,transform.position+offset);
		}
	}
}
