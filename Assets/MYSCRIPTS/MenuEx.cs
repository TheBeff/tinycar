using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuEx : MonoBehaviour {

	public Button myButton; 
	public Canvas CanvasMain; 

	public GameObject canvasTwo; 

	// Use this for initialization
	void Start () {

		Button btn = myButton.GetComponent<Button> (); 
		btn.onClick.AddListener (TaskOnClick); 
//		GameObject.GetComponent<Canvas> ().enabled = true;
//		canvasTwo = GameObject.GetComponent<Canvas> ();

	}
	
	// Update is called once per frame
	void TaskOnClick () {

		Debug.Log ("You have clicked the button!"); 
	//	GameObject.SetActive(false);
		//canvasTwo.SetActive(true); 

	}

}
