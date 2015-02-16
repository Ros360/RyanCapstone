using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour 
{
	public bool canPause;
	// Use this for initialization
	void Start () 
	{
		canPause = true;
	}


	void OnGUI () 
	{
		if (GUI.Button (new Rect (630, 15, 100, 50), "Pause Button")) 
		{
			if (canPause)
			{
				Time.timeScale = 0;
				canPause = false;
			}
			else
			{
				Time.timeScale = 1;
				canPause = true;
			}
		}
	}
}
