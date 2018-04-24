using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Timer : MonoBehaviour {

	public TextMeshProUGUI timerText; 
	private float startTime; 

	void Start () {

		startTime = Time.deltaTime; 

	}
	
	// Update is called once per frame
	void Update () {

		float t = Time.time - startTime; 
		string minutes = ((int) t / 60).ToString ("f0"); 
		string seconds = (t % 60).ToString ("f1"); 

		timerText.text = minutes + ":" + seconds; 
	}
}
