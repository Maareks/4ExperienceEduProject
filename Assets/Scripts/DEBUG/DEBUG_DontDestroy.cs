﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEBUG_DontDestroy : MonoBehaviour {

	// Use this for initialization
	void Awake(){
		DontDestroyOnLoad (gameObject);
	}
}
