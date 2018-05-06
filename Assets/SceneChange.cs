using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour {

	 void OnMouseDown()
	{
		//	if (GameObject.FindWithTag == "BONE") { 
		//	if (GameObject.FindGameObjectsWithTag == "BONE") { 
			
		Debug.Log ("PRESSED."); 
	
		SceneManager.LoadScene ("A");
	
	} 
	

	void OnCollisionEnter(Collision col) {

		if (col.gameObject.tag == "BONE") {

			Debug.Log ("This happened."); 

		} 

	} 
} 