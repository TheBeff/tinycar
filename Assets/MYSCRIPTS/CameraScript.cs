using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public int distanceAwayZ = 5; 
	public int distanceAwayY = 4; 
	public GameObject player;
//	public Camera cam = GetComponent<Camera>();

	// Use this for initialization
	void Start () {

	

	}

	// Update is called once per frame
	void Update () {

		Vector3 PlayerPOS = player.transform.position;  
		Debug.Log (PlayerPOS);
		transform.position = new Vector3 (PlayerPOS.x, PlayerPOS.y + distanceAwayY, PlayerPOS.z - distanceAwayZ); 

	}


	void OnCollisionEnter (Collision col) {  
	
//		if (col.gameObject.name == "CameraCollider") {     
//			   
//			Debug.Log ("This happened."); 	
//			Vector3 PlayerPOS = player.transform.position;  
//			transform.position = new Vector3 (PlayerPOS.x, PlayerPOS.y + 7, PlayerPOS.z - 8); 
//		
//		} 

			//rotate from 36 - 24 on X  

		//	Vector3 rotateCamera = mainCamera.rotate; 


		//	Vector3 newRotation = Vector3.RotateTowards ( 


		//	Vector3 CameraRotate = cam.transform.Rotate; 
		//	Transform.Rotate (12, 0, 0); 

			//= new Vector3 (-12.0f, 0, 0); 

	}
}
