﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	void OnTriggerEnter(Collider col) {

		if (col.gameObject.tag == "Player") {     

			Debug.Log ("This happened."); 	
		} 

	} 
}
