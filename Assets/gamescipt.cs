﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamescipt : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit(); 
	}
	}
}
