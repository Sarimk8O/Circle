using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System.Text;




public class Score_Count : MonoBehaviour {

	private float Score;
	private float HighScore;
	public Text Points;


	// Use this for initialization
	void Start () {

		if (PlayerPrefs.GetFloat ("Score") != null) 
		{
			HighScore = PlayerPrefs.GetFloat ("Score");
			//Debug.Log ("High Score is " + HighScore);
		}

		Points.text = "0";

		


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Circle") 
		{
			Score += 1;
		Points.text = ""+Score;

			if (Score > HighScore) 
			{
				HighScore = Score;
			}

			PlayerPrefs.SetFloat ("Score", HighScore);
			//Debug.Log ("Score is " + Score);
		}
	}
}
