using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootBall : MonoBehaviour
{
	
	public float force = 100.0f;
	public string buttonName = "Fire1";
	
	private List<Rigidbody> ballList = new List<Rigidbody>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetButtonDown(buttonName))
		{
			foreach(Rigidbody ball in ballList)
			{
				Debug.Log ("Applying Force");
				ball.AddForce(Vector3.forward*force,ForceMode.VelocityChange);
			}
		}
	}
	
	void OnTriggerEnter(Collider col)
	{
		Debug.Log("Object Entered");
		if(col.rigidbody)
		{
			Debug.Log("Object Has Rigidbody");
			ballList.Add(col.rigidbody);
		}
	}
	
	void OnTriggerExit(Collider col)
	{
		Debug.Log("Object Exited");
		if(col.rigidbody)
		{
			Debug.Log("Object Has Rigidbody");
			ballList.Remove(col.rigidbody);
		}
	}
}
