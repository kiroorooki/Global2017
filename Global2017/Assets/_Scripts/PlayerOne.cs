using UnityEngine;
using System.Collections;

public class PlayerOne : MonoBehaviour {

	private float playerOneSpeed;
	public float normalSpeed;
	public float sneakySpeed;

	PlayerController controller;


	void Start () {
		playerOneSpeed = normalSpeed;
	}

	void Awake() {
		controller = GetComponent<PlayerController> ();
	}

	void Update () {
		// Déplacement Normal
		Vector3 moveInput = new Vector3 (Input.GetAxisRaw ("HorizontalP1"), 0, Input.GetAxisRaw ("VerticalP1"));
		Vector3 moveVelocity = moveInput.normalized * playerOneSpeed;
		controller.Move (moveVelocity);
		Debug.Log(Input.GetAxisRaw ("VerticalP1"));

		// Déplacement Sneaky
		if (Input.GetButtonDown ("Slow")) {
			playerOneSpeed = sneakySpeed;
		}
		if (Input.GetButtonUp ("Slow")) {
			playerOneSpeed = normalSpeed;
		}

	}

}
