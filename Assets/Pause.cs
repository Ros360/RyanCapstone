using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour 
{
	public bool canPause;
	string buttonText = "Play";
	// Use this for initialization
	void Start () 
	{
		canPause = false;
		Time.timeScale=0;
	}


	void OnGUI () 
	{
		if (GUI.Button (new Rect (630, 15, 100, 50), buttonText)) 
		{
			if (canPause)
			{
				Time.timeScale = 0;
				canPause = false;
				buttonText = "Play";
			}
			else
			{
				Time.timeScale = 1;
				canPause = true;
				buttonText = "Pause";
			}
		}
	}
}
