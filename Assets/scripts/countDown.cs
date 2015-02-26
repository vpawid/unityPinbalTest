using UnityEngine;
using System.Collections;

public class countDown : MonoBehaviour {

public float timer = 30f;
public int screenwidth;
public int screenheight;
public int sizeone;
public int sizetwo;
public GUIStyle custom;

void Update()
{
	timer -= Time.deltaTime;
	if(timer <=0)
	{
		timer = 0;
		Application.LoadLevel(0);
	}
}

void OnGUI()
{
	GUI.Box(new Rect(sizeone,sizetwo,screenwidth, screenheight), timer.ToString(), custom);
}	

}
