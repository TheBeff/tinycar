using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MovementScript : MonoBehaviour {

	public float spaceRotateX; 
	public float spaceRotateY; 
	public float spaceRotateZ; 

	public float speed = 6.0f; 
	private Vector3 moveDirection = Vector3.zero; 
	public bool letsJump; 

	public Animator anim; 
	public Rigidbody rb; 
	public float jumpHeight = 200.0f; 

	public GameObject winCollider; 
	public AudioSource vroom; 
	public AudioSource jumpSound; 


	void Start () {

		anim = GetComponentInChildren<Animator> (); 
		rb = GetComponent<Rigidbody> (); 
		AudioSource vroom = GetComponent<AudioSource> (); 
		AudioSource jumpSound = GetComponent<AudioSource> (); 


	}

	void Update () {

//		CharacterController cAR = GetComponent<CharacterController> (); 
//
//		if (cAR.isGrounded) { 
//
//			moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")); 
//			moveDirection =	transform.TransformDirection (moveDirection); 
//			moveDirection *= speed; 
//
//			if (Input.GetButton ("Jump"))
//				moveDirection.y = jumpSpeed; 
//		} 
//
//		moveDirection.y -= gravity * Time.deltaTime; 
//		cAR.Move (moveDirection * Time.deltaTime); 
//
	
		
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
		var y = Input.GetAxis("Vertical") * Time.deltaTime * 50.0f;

		transform.Rotate(0, x, 0);
		transform.Translate (0, 0, z); 

		if (Input.GetKeyDown ("up")) {
			vroom.Play (); 	
		}


		if (Input.GetKeyDown("space")) {

			Debug.Log ("Works?"); 
			anim.SetTrigger ("jump");

			float move = Input.GetAxis ("Vertical"); 
			anim.SetFloat ("Speed", move); 
			// add force to rigid body 
			rb.AddForce (0, jumpHeight, 0);
			jumpSound.Play (); 	

		} 
	
	}

	void OnCollisionEnter(Collision col) {
	
		if (col.gameObject.name == "LoseCollider") { 

			SceneManager.LoadScene ("LOSESCENE"); 
			Tinylytics.AnalyticsManager.LogCustomMetric("Time of death", Time.time.ToString());
			
		} 

		if (col.gameObject.name == "WinCollider") { 

			SceneManager.LoadScene ("WINSCENE"); 
		} 

	}
}
