using UnityEngine;
using System.Collections;

public class BGMusic : MonoBehaviour {
	
	public static int numbTrack = 0;
	
	// Use this for initialization   

	void Start () {
		
		GameObject.DontDestroyOnLoad(gameObject);

		if(audio.isPlaying && numbTrack > 0 )
		{
			Destroy(gameObject);
			
		}
		
		
		numbTrack++;
	}
}
	

