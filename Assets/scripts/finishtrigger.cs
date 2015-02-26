using UnityEngine;
using System.Collections;

public class finishtrigger : MonoBehaviour {

	// Use this for initialization
	void OnTriggerExit(Collider goal)
	{
		Application.LoadLevel(2);
	}
}