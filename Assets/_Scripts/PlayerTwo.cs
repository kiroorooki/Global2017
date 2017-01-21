using UnityEngine;
using System.Collections;

public class PlayerTwo : MonoBehaviour {

	private float playerTwoSpeed;
	public float normalSpeed;
	public float sneakySpeed;

    float holdButtonTime = 0f;
    public float maxForce;
    public float timeToMax;

    PlayerController controller;
    public Projectile projectile;

    private GameObject AttackCone;
    
    public float KatanaRange;
    public float KatanaAngle;
    public GameObject Cone;
    public float delay;

    bool AttackON = false;
	bool isSneaky = false;

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
		if (Input.GetButtonDown ("SlowP2")) {
			playerTwoSpeed = sneakySpeed;
			isSneaky = true;
		}
		if (Input.GetButtonUp ("SlowP2")) {
			playerTwoSpeed = normalSpeed;
			isSneaky = false;
		}
		
        AttackP2();
        Projectiles();
		
    }

    void Projectiles()
    {
        // Projectiles
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
                e.GetComponent<Rigidbody>().AddForce(direction * maxForce * holdButtonTime);

                holdButtonTime = 0f;
            }
        }
    }
    void AttackP2()
    {
		// Attaque
        if (Input.GetButtonDown("FireP2") && !AttackON) 
        {
            AttackON = true;
            playerTwoSpeed = 0;
            sneakySpeed = 0;
            Vector3 direction = (new Vector3(Input.GetAxisRaw("ShootXP2"), 0, -Input.GetAxisRaw("ShootYP2"))) * (-1f);
            direction = direction.normalized;

            AttackCone = Instantiate(Cone, transform.position, Quaternion.identity);
            AttackCone.transform.parent = transform;
            AttackCone.transform.LookAt(transform.position + direction);

            Physics.IgnoreCollision(AttackCone.GetComponent<Collider>(), GetComponent<Collider>());
            StartCoroutine(DelayAttack());
            MeshCollider ConeMesh = AttackCone.GetComponent<MeshCollider>();

        }
    }

    IEnumerator DelayAttack()
    {
        yield return new WaitForSeconds(delay);
        playerTwoSpeed = normalSpeed;
        sneakySpeed = playerTwoSpeed;
        Destroy(AttackCone);
        AttackON = false;
    }

    void OntriggerEnter(Collider other)
    {
        Debug.Log("Touche " + other);
        //Instantiate (Blood, other.transform.position, other.transform.rotation)
        Destroy(other.gameObject);
    }

}
