using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public int distanceAwayZ = 5; 
	public int distanceAwayY = 4; 
	public GameObject player;


	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

		Vector3 PlayerPOS = player.transform.position;  
		Debug.Log (PlayerPOS);
		transform.position = new Vector3 (PlayerPOS.x, PlayerPOS.y + distanceAwayY, PlayerPOS.z - distanceAwayZ); 

	}
}
