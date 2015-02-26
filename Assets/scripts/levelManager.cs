using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class levelManager : MonoBehaviour {

public static int score = 1;
	

	
	public void LoadMenu()
	{
		texteditor.score = 0;
		Application.LoadLevel(0);
	}
	
	
	public void LoadGame()
	{
		texteditor.score = 0;
		Application.LoadLevel(1);
	
	}
	
	public void quitGame()
	{
		texteditor.score = 0;
		Application.Quit();
	}
	
	
	
	public void LoadFinal()
	{
		texteditor.score = 0;
		Application.LoadLevel(4);
	}
}
