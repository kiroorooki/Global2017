using UnityEngine;
using System.Collections;

public class PlayerTwo : MonoBehaviour {

	private float playerTwoSpeed;
	public float normalSpeed;
	public float sneakySpeed;

	PlayerController controller;


	void Start () {
		playerTwoSpeed = normalSpeed;
	}

	void Awake() {
		controller = GetComponent<PlayerController> ();
	}

	void Update () {
		// Déplacement Normal
		Vector3 moveInput = new Vector3 (Input.GetAxisRaw ("HorizontalP2"), 0, Input.GetAxisRaw ("VerticalP2"));
		Vector3 moveVelocity = moveInput.normalized * playerTwoSpeed;
		controller.Move (moveVelocity);

		// Déplacement Sneaky
		if (Input.GetButtonDown ("Slow")) {
			playerTwoSpeed = sneakySpeed;
		}
		if (Input.GetButtonUp ("Slow")) {
			playerTwoSpeed = normalSpeed;
		}

	}

}
