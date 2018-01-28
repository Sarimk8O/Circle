using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Circle_Rotation : MonoBehaviour {

	public float movespeed;
	public float turningSpeed;
	private Rigidbody2D rb;

	public Vector3 eulerAngleVelocity;

	// Use this for initialization
	void Start () {

		rb=GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		transform.Rotate (new Vector3 (0, 0, movespeed * turningSpeed*Time.fixedDeltaTime));
		//rigibody.MoveRotation (movespeed);
		//Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
		//rb.MoveRotation ( deltaRotation.z);
		
	}
}
