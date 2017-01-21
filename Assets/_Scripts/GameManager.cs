using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class GameManager : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;
	public GameObject player3;
	public GameObject player4;

	public bool player1Play = false;
	public bool player2Play = false;
	public bool player3Play = false;
	public bool player4Play = false;

	bool playersSpawn = false;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;


    }

	void Update(){

		if (playersSpawn == false && SceneManager.GetActiveScene ().name == "Main") {
			if (player1Play == true) {
				Instantiate (player1, new Vector3 (-20f,1.2f,0f), player1.transform.rotation);
			}
			if (player2Play == true) {
				Instantiate (player2, new Vector3 (20f,1.2f,0f), player2.transform.rotation);
			}
			if (player3Play == true) {
				Instantiate (player3, new Vector3 (0f,1.2f,-12f), player3.transform.rotation);
			}
			if (player4Play == true) {
				Instantiate (player4, new Vector3 (0f,1.2f,12f), player4.transform.rotation);
			}
			playersSpawn = true;
		}
	}
}
