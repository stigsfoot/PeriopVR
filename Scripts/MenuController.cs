﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour, IGvrGazeResponder {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	#region IGvrGazeResponder implementation

	public void OnGazeEnter ()
	{
		//Debug.Log("Entered Gaze");
	}

	public void OnGazeExit ()
	{
		//Debug.Log("Gaze Exit");
	}

	public void OnGazeTrigger ()
	{
		//Debug.Log("Clicked");
	}

	#endregion
}
