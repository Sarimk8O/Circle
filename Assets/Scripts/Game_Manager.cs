using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Game_Manager : MonoBehaviour {

	public GameObject[] Circle;

	public int number;

	public float Delay;
	private Vector2 firstTouch;
	private Vector2 lastTouch;
	private float dragDistance;

	public Vector2 velocity;
	public float smoothTime;


	//private float lerpTime = 1f;
	private float currentlerpTime;


	public float Speed;

	private Vector3 compare = new Vector3 (0.5f, 0.5f,0.0f);
	public Vector2 Origin;
	// Use this for initialization
	void Start () {
		//Debug.Log ("Start");
		dragDistance = Screen.height * 15 / 100;

		StartCoroutine ("RandomSelect");

		//SpriteRenderer Renderer = GetComponent<SpriteRenderer> ();
		
	}




	
	public IEnumerator RandomSelect(){

		while (true) {
			//Ball_Moment ();

			//Debug.Log ("In While Loop");
	
			number = Random.Range (0, Circle.Length);




			if (number == 0) {
				
				Circle [1].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [2].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [3].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [4].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [5].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [6].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [7].transform.localScale = new Vector2 (0.3f, 0.3f);

				yield return new WaitForSeconds (smoothTime);

				Circle [0].transform.localScale = new Vector2 (0.5f, 0.5f);

				yield return new WaitForSeconds (Delay);
			} else if (number == 1) {
				
				Circle [0].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [2].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [3].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [4].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [5].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [6].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [7].transform.localScale = new Vector2 (0.3f, 0.3f);

				yield return new WaitForSeconds (smoothTime);

				Circle [1].transform.localScale = new Vector2 (0.5f, 0.5f);


				yield return new WaitForSeconds (Delay);
			
			} else if (number == 2) {
				
			 
				Circle [0].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [1].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [3].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [4].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [5].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [6].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [7].transform.localScale = new Vector2 (0.3f, 0.3f);

				yield return new WaitForSeconds (smoothTime);

				Circle [2].transform.localScale = new Vector2 (0.5f, 0.5f);

			
				yield return new WaitForSeconds (Delay);
			
			} else if (number == 3) {
				
			
				Circle [0].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [2].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [1].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [4].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [5].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [6].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [7].transform.localScale = new Vector2 (0.3f, 0.3f);

				yield return new WaitForSeconds (smoothTime);

				Circle [3].transform.localScale = new Vector2 (0.5f, 0.5f);


				yield return new WaitForSeconds (Delay);
			
			} else if (number == 4) {
				
			
				Circle [0].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [2].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [3].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [1].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [5].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [6].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [7].transform.localScale = new Vector2 (0.3f, 0.3f);

				yield return new WaitForSeconds (smoothTime);

				Circle [4].transform.localScale = new Vector2 (0.5f, 0.5f);


				yield return new WaitForSeconds (Delay);
			
			} else if (number == 5) {
				
				Circle [4].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [0].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [2].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [3].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [1].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [6].transform.localScale = new Vector2 (0.3f, 0.3f);

				//yield return new WaitForSeconds (smoothTime);

				Circle [7].transform.localScale = new Vector2 (0.3f, 0.3f);

				yield return new WaitForSeconds (smoothTime);

				Circle [5].transform.localScale = new Vector2 (0.5f, 0.5f);


				yield return new WaitForSeconds (Delay);
			} else if (number == 6) {

				Circle [4].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [0].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [2].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [3].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [1].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [5].transform.localScale = new Vector2 (0.3f, 0.3f);

				//yield return new WaitForSeconds (smoothTime);

				Circle [7].transform.localScale = new Vector2 (0.3f, 0.3f);

				yield return new WaitForSeconds (smoothTime);
				
				Circle [6].transform.localScale = new Vector2 (0.5f, 0.5f);


				yield return new WaitForSeconds (Delay);
			
			
			} else if (number == 7) {
				Circle [4].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [0].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [2].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [3].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [1].transform.localScale = new Vector2 (0.3f, 0.3f);
				Circle [5].transform.localScale = new Vector2 (0.3f, 0.3f);

				yield return new WaitForSeconds (smoothTime);

				Circle [6].transform.localScale = new Vector2 (0.3f, 0.3f);
				


				Circle [7].transform.localScale = new Vector2 (0.5f, 0.5f);


				yield return new WaitForSeconds (Delay);
			
			}


		}
	
	}

	void FixedUpdate(){
		//Ball_Moment ();
		//StartCoroutine ("RandomSelect");

		if (Circle[number].transform.localScale == compare) 
		{
			//Debug.Log ("Circle" + number + "is Activr");
			Ball_Moment (number);
		}

	/*	if (number == 0) {
			Debug.Log (number);
			Ball_Moment (0);

		} else if (number == 1) {
			Debug.Log (number);
			Ball_Moment (1);

		}
		else if (number == 2) {
			Debug.Log (number);
			Ball_Moment (2);

		} else if (number == 3) {
			Debug.Log (number);
			Ball_Moment (3);

		} else if (number == 4) {
			Debug.Log (number);
			Ball_Moment (4);

		} else if (number == 5) {
			Debug.Log (number);
			Ball_Moment (5);

		} else if (number == 6) {
			Debug.Log (number);
			Ball_Moment (6);

		} else if (number == 7) {
			Debug.Log (number);
			Ball_Moment (7);

		}*/

	}


	public void Ball_Moment(int i)
	{
		if (Input.touchCount == 1) 
		{
			Touch touch = Input.GetTouch (0);

			if (touch.tapCount == 1) 
			{
				
				//Debug.Log ("Tap is Once");
				float NewSpeed = 1f-Mathf.Sin (Speed*Mathf.PI*0.5f);
				Circle[i].transform.position=Vector2.Lerp(Circle[i].transform.position,Origin,Time.deltaTime*NewSpeed);
				//Circle [i].GetComponent<Rigidbody2D> ().MovePosition (Circle[i].transform.position+ Origin*Time.deltaTime*Speed);
				//Circle[i].GetComponent<Rigidbody2D>().
				//Circle [i].transform.position = Vector2.MoveTowards (Circle [i].transform.position, Origin, NewSpeed);
				//Circle [i].transform.position = Vector2.LerpUnclamped (Circle [i].transform.position, Origin, NewSpeed);
				//Circle [i].transform.position = Vector2.SmoothDamp (Circle[i].transform.position,Origin,ref velocity,smoothTime,NewSpeed,Time.deltaTime);
			}

			/*if (touch.phase == TouchPhase.Began) {
				firstTouch = touch.position;
				lastTouch = touch.position;
			} else if (touch.phase == TouchPhase.Moved) {
				lastTouch = touch.position;
			} else if (touch.phase == TouchPhase.Ended) {
			
				lastTouch = touch.position;
			}

			if (Mathf.Abs (lastTouch.x - firstTouch.x) > dragDistance || Mathf.Abs (lastTouch.y - firstTouch.y) > dragDistance) {
				if (Mathf.Abs (lastTouch.x - firstTouch.x) > Mathf.Abs (lastTouch.y - firstTouch.y)) {
					if (lastTouch.x > firstTouch.x) {
						Debug.Log ("Right Swip");
					} else {
						Debug.Log ("Left Swip");
					}
				} else {
					if (lastTouch.y > firstTouch.y) {
						Debug.Log ("up swip");



					} else {
						Debug.Log ("down swip");
					}
				}
			} else 
			{
				Debug.Log ("tap");
				//Circle[i].GetComponent<Rigidbody2D>().MovePosition(new Vector2(0,0)*Speed*Time.fixedDeltaTime);
				//Circle[i].transform.position=new Vector2(0,0);
				//Circle[i].GetComponent<Rigidbody2D>().AddForce(Vector2.zero*Speed);
				//Circle[i].transform.Translate(Vector2.zero*Time.deltaTime);
				Circle[i].transform.position=Vector2.Lerp(Circle[i].transform.position,Origin,Speed*Time.deltaTime);
			

			}*/


		
		
		}
		
	}

	public IEnumerator Delay1()
	{
		yield return new WaitForSeconds (smoothTime);
	}
}
