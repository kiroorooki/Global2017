using UnityEngine;
using System.Collections;

public class PlayerTwo : MonoBehaviour {

	private float playerTwoSpeed;
	public float normalSpeed;
	public float sneakySpeed;

    float holdButtonTime = 0f;
    public float maxForce = 2500f;
    public float timeToMax = 1f;

    PlayerController controller;
    public Projectile projectile;

    


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


        // projectiles
        if (Input.GetButton("ThrowP2"))
        {
            holdButtonTime += Time.deltaTime;
            holdButtonTime = Mathf.Clamp(holdButtonTime, 0f, timeToMax);
        }

        if (Input.GetButtonUp("ThrowP2"))
        {
            Vector3 direction = (new Vector3(Input.GetAxisRaw("ShootXP2"), 0, -Input.GetAxisRaw("ShootYP2"))) * (-1f);
            if (direction != Vector3.zero)
            { 
                Projectile e = Instantiate(projectile, transform.position, Quaternion.identity);
                Physics.IgnoreCollision(e.GetComponent<Collider>(), GetComponent<Collider>());
            
                direction = direction.normalized;
                e.GetComponent<Rigidbody>().AddForce(direction * 5000f * holdButtonTime);

                holdButtonTime = 0f;
            }
        }

    }

}
