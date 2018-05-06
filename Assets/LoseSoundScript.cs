using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseSoundScript : MonoBehaviour {

	public AudioSource deathSound; 

	void Start () {

	//	AudioSource deathSound = GetComponent<AudioSource> (); 
		
	}
	
	void OnCollisionEnter(Collision col) {

		if (col.gameObject.tag == "Player") {

			Debug.Log ("HI"); 
			//deathSound.Play (); 

		}
	}

} 