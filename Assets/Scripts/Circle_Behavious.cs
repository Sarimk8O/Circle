using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_Behavious : MonoBehaviour {

	public float time;
	public Vector2 Original_Position;
	public float Place;



	//private Rigidbody2D rigibody;

	// Use this for initialization
	void Start () {
		
		//rigibody = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Game_Over") {
			//Debug.Log ("Game Over");
		}else if (other.gameObject.tag == "Back_To_Original") 
		{
			//Debug.Log ("Its working");

			//yield return StartCoroutine ("Delay");
			StartCoroutine("Delay");
		} 

	}




	public IEnumerator Delay()
	{

		Debug.Log ("In Coroutine");
		yield return new WaitForSeconds (time);

		gameObject.transform.position = Vector2.Lerp (gameObject.transform.position, Original_Position, Place);
		//rigibody.MovePosition (Original_Position*Time.deltaTime);
		//gameObject.transform.position=new Vector2(2,0);
	}




}
