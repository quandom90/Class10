﻿using UnityEngine;
using System.Collections;

public class LerpTest : MonoBehaviour {

	private float _currentLerp;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		_currentLerp = Mathf.Lerp (1, 10, 1f);
		Debug.Log ("lerpValue: " + _currentLerp);
	}
}
