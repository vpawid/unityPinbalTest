using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class texteditor : MonoBehaviour {

	public Text scoreText;
	public static int score = 0;

	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score : " + score.ToString();
		
	
	}
}
