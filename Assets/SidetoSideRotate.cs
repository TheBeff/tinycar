using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidetoSideRotate : MonoBehaviour {

	public float speed = 2f;
	public float maxRotation = 45f;

	void Start () {
		
	}


void Update()
{
		transform.rotation = Quaternion.Euler(0f, 0f, maxRotation * Mathf.Sin(Time.time * speed));
}
} 