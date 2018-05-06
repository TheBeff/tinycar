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
	public AudioSource deadSound; 
	public GameObject selfCollider; 

	public AudioClip deathClip;
	public bool alreadyPlayed = false; 

	private float tinyTime; 

	public Renderer selfText;

	void Start () {

		anim = GetComponentInChildren<Animator> (); 
		rb = GetComponent<Rigidbody> (); 

		AudioSource vroom = GetComponent<AudioSource> (); 
		AudioSource jumpSound = GetComponent<AudioSource> (); 
		AudioSource deadSound = GetComponent<AudioSource> (); 

		selfText = GetComponent<Renderer> (); 
		selfText.enabled = true; 

	}

	void FixedUpdate () {
		
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
				rb.AddForce (0, jumpHeight, 0);
				jumpSound.Play (); 	

		} 
	
	}

	private IEnumerator WaitForSceneLoad() {
		yield return new WaitForSeconds (3); 
			SceneManager.LoadScene("LOSESCENE"); 
	} 

	void OnCollisionEnter(Collision col) {


		if (col.gameObject.name == "NewCollider") {

			Debug.Log ("This happened."); 

		} 

	
		if (col.gameObject.name == "Self") {

			Debug.Log ("This happened."); 
			selfText.enabled = false; 
			SceneManager.LoadScene ("WINSCENE"); 

		}  

		if (col.gameObject.name == "LoseCollider") { 
			
		//	AudioSource.PlayClipAtPoint(deathClip, new Vector3(5, 1, 2));
			if (!alreadyPlayed) { 
				deadSound.Play (); 
				alreadyPlayed = true; 
			}
			StartCoroutine(WaitForSceneLoad());

			Tinylytics.AnalyticsManager.LogCustomMetric("Time of death", Time.time.ToString());

		} 

		if (col.gameObject.name == "WinCollider") { 

			SceneManager.LoadScene ("WINSCENE"); 
		
		} 
			
		//	Vector3 PlayerPOS = player.transform.position;  
		//	transform.position = new Vector3 (PlayerPOS.x, PlayerPOS.y + 7, PlayerPOS.z - 8); 

	}
}
