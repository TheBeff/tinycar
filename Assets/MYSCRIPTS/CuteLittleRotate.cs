using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuteLittleRotate : MonoBehaviour {

	public float speed = Random.Range (2f, 5f);
	public float maxRotation = Random.Range (40f, 70f);

	void Start () {

	}


	void Update()
	{
		transform.rotation = Quaternion.Euler(0f, maxRotation * Mathf.Sin(Time.time * speed), 0f);
	}
} 