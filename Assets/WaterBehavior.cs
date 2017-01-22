using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") 
		{
			if (other.GetComponent<PlayerOne> ()) 
			{
				Debug.Log ("ToucheEau");
				other.GetComponent<PlayerOne> ().isWalkingOnWater = true;

			}

			if (other.GetComponent<PlayerTwo> ()) 
			{
				Debug.Log ("ToucheEau");
				other.GetComponent<PlayerTwo> ().isWalkingOnWater = true;

			}

			if (other.GetComponent<PlayerThree> ()) 
			{
				Debug.Log ("ToucheEau");
				other.GetComponent<PlayerThree> ().isWalkingOnWater = true;

			}

			if (other.GetComponent<PlayerFour> ()) 
			{
				Debug.Log ("ToucheEau");
				other.GetComponent<PlayerFour> ().isWalkingOnWater = true;

			}


				
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.tag == "Player") {
			if (other.GetComponent<PlayerOne> ()) {
				Debug.Log ("ToucheEau");
				other.GetComponent<PlayerOne> ().isWalkingOnWater = false;
			}
			if (other.GetComponent<PlayerTwo> ()) 
			{
				Debug.Log ("ToucheEau");
				other.GetComponent<PlayerTwo> ().isWalkingOnWater = false;

			}

			if (other.GetComponent<PlayerThree> ()) 
			{
				Debug.Log ("ToucheEau");
				other.GetComponent<PlayerThree> ().isWalkingOnWater = false;

			}

			if (other.GetComponent<PlayerFour> ()) 
			{
				Debug.Log ("ToucheEau");
				other.GetComponent<PlayerFour> ().isWalkingOnWater = false;

			}
		}
	}
}
