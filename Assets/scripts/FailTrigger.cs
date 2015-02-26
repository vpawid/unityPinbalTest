using UnityEngine;
using System.Collections;

public class FailTrigger : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter( Collider fail)
	{
		Application.LoadLevel(3);
	}
}
