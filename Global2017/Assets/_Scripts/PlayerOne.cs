using UnityEngine;
using System.Collections;

public class PlayerOne : MonoBehaviour {

	private float playerOneSpeed;
	public float normalSpeed;
	public float sneakySpeed;

    float holdButtonTime = 0f;
    public float maxForce = 2500f;
    public float timeToMax = 1f;


    PlayerController controller;
    public Projectile projectile;

    

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

		// Déplacement Sneaky
		if (Input.GetButtonDown ("Slow")) {
			playerOneSpeed = sneakySpeed;
		}
		if (Input.GetButtonUp ("Slow")) {
			playerOneSpeed = normalSpeed;
		}

        // projectiles
        if (Input.GetButton("ThrowP1"))
        {
            holdButtonTime += Time.deltaTime;
            holdButtonTime = Mathf.Clamp(holdButtonTime, 0f, timeToMax);
        }

        if (Input.GetButtonUp("ThrowP1"))
        {
            Vector3 direction = (new Vector3(Input.GetAxisRaw("ShootXP1"), 0, (-1f) * Input.GetAxisRaw("ShootYP1"))) * (-1f);



            if (direction != Vector3.zero)
            {
                Projectile e = Instantiate(projectile, transform.position, Quaternion.identity);
                Physics.IgnoreCollision(e.GetComponent<Collider>(), GetComponent<Collider>());

                direction = direction.normalized;
                e.GetComponent<Rigidbody>().AddForce(direction * maxForce * holdButtonTime);

                holdButtonTime = 0f;
            }
        }


    }



}
