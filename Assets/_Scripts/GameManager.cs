using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;
using XInputDotNetPure;

public class GameManager : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;
	public GameObject player3;
	public GameObject player4;

	public bool player1Play = false;
	public bool player2Play = false;
	public bool player3Play = false;
	public bool player4Play = false;


	private PlayerOne P1;
	private PlayerTwo P2;
	private PlayerThree P3;
	private PlayerFour P4;


	bool playersSpawn = false;
	public float timer = 1f;




	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;


    }



	void OnEnable() {

	}

	bool notDone = true;
	void Update(){

		if (playersSpawn == false && SceneManager.GetActiveScene ().name == "Main") {
			StartCoroutine (ActivatePlayer());
			playersSpawn = true;

		} else if (SceneManager.GetActiveScene ().name == "Main") {









			/*
			if (timer >= 0) {
				if (player1Play == true) {
					player1.transform.Find ("Ninja (1)").gameObject.SetActive(true);
					player1.GetComponent<PlayerOne> ().enabled = false;
				}
				if (player2Play == true) {
					player2.transform.Find ("Ninja").gameObject.SetActive(true);
					player2.GetComponent<PlayerTwo> ().enabled = false;
				}
				if (player3Play == true) {
					player3.transform.Find ("Ninja 3 (1)").gameObject.SetActive(true);
					player3.GetComponent<PlayerThree> ().enabled = false;
				}
				if (player4Play == true) {
					player4.transform.Find ("Ninja").gameObject.SetActive(true);
					player4.GetComponent<PlayerFour> ().enabled = false;
				}
			} else {
				if (player1Play == true) {
					player1.transform.Find ("Ninja (1)").gameObject.SetActive(false);
					player1.GetComponent<PlayerOne> ().enabled = true;
				}
				if (player2Play == true) {
					player2.transform.Find ("Ninja").gameObject.SetActive(false);
					player2.GetComponent<PlayerTwo> ().enabled = true;
				}
				if (player3Play == true) {
					player3.transform.Find ("Ninja 3 (1)").gameObject.SetActive(false);
					player3.GetComponent<PlayerThree> ().enabled = true;
				}
				if (player4Play == true) {
					player4.transform.Find ("Ninja").gameObject.SetActive(false);
					player4.GetComponent<PlayerFour> ().enabled = true;
				}
			}

*/
		}
	}

	IEnumerator ActivatePlayer() {
		yield return null;
		if (player1Play == true) {
			P1 =  Instantiate (player1, new Vector3 (-20f, 1.2f, 0f), player1.transform.rotation).GetComponent<PlayerOne>();
			P1.enabled = false;
		}
		if (player2Play == true) {
			P2 = Instantiate (player2, new Vector3 (20f, 1.2f, 0f), player2.transform.rotation).GetComponent<PlayerTwo>();
			P2.enabled = false;
		}
		if (player3Play == true) {
			P3 = Instantiate (player3, new Vector3 (0f, 1.2f, -12f), player3.transform.rotation).GetComponent<PlayerThree>();
			P3.enabled = false;
		}
		if (player4Play == true) {
			P4 = Instantiate (player4, new Vector3 (0f, 1.2f, 12f), player4.transform.rotation).GetComponent<PlayerFour>();
			P4.enabled = false;
		}

		yield return new WaitForSeconds (1f);

		if (P1) {
			P1.transform.GetChild (0).gameObject.SetActive (false);
			P1.enabled = true;
		}
		if (P2) {
			P2.transform.GetChild (0).gameObject.SetActive (false);
			P2.enabled = true;
		}
		if (P3) {
			P3.transform.GetChild (0).gameObject.SetActive (false);
			P3.enabled = true;
		}
		if (P4) {
			P4.transform.GetChild (0).gameObject.SetActive (false);
			P4.enabled = true;
		}
	}
}
