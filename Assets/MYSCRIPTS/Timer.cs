using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Timer : MonoBehaviour {

	public TextMeshProUGUI timerText; 
	private float timeSinceStart; 


	void Start () {

		timeSinceStart = 0;
	}
	
	// Update is called once per frame
	void Update () {

		timeSinceStart += Time.deltaTime;
		string minutes = ((int)timeSinceStart / 60).ToString ("f0"); 
		string seconds = (timeSinceStart % 60).ToString ("f1"); 
		if (timeSinceStart >= 60) {
			timerText.text = minutes + ":" + seconds; 
		} else {
			timerText.text = seconds;
		}
	}
}
