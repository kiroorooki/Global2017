using UnityEngine;
using System.Collections;

public class PlayerFour : MonoBehaviour {

	private float playerFourSpeed;
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

    void Start () {
		playerFourSpeed = normalSpeed;
	}

	void Awake() {
		controller = GetComponent<PlayerController> ();
	}

	void Update () {
		// Déplacement Normal
		Vector3 moveInput = new Vector3 (Input.GetAxisRaw ("HorizontalP4"), 0, Input.GetAxisRaw ("VerticalP4"));
		Vector3 moveVelocity = moveInput.normalized * playerFourSpeed;
		controller.Move (moveVelocity);

		// Déplacement Sneaky
		if (Input.GetButtonDown ("SlowP4")) {
			playerFourSpeed = sneakySpeed;
		}
		if (Input.GetButtonUp ("SlowP4")) {
			playerFourSpeed = normalSpeed;
		}
        AttackP2();
        Projectiles();
    }

    void Projectiles()
    {
        // projectiles
        if (Input.GetButton("ThrowP4"))
        {
            holdButtonTime += Time.deltaTime;
            holdButtonTime = Mathf.Clamp(holdButtonTime, 0f, timeToMax);
        }

        if (Input.GetButtonUp("ThrowP4"))
        {
            Vector3 direction = (new Vector3(Input.GetAxisRaw("ShootXP4"), 0, -Input.GetAxisRaw("ShootYP4"))) * (-1f);
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
        if (Input.GetButtonDown("FireP4") && !AttackON) 
        {
            AttackON = true;
            print("FireP4");
            playerFourSpeed = 0;
            sneakySpeed = 0;
            Debug.Log("Slash");
            Vector3 direction = (new Vector3(Input.GetAxisRaw("ShootXP4"), 0, -Input.GetAxisRaw("ShootYP4"))) * (-1f);
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
        playerFourSpeed = normalSpeed;
        sneakySpeed = playerFourSpeed;
        Destroy(AttackCone);
        AttackON = false;
    }

    void OntriggerEnter(Collider other)
    {
        Debug.Log("Touche");
        //Instantiate (Blood, other.transform.position, other.transform.rotataion)
        Destroy(other.gameObject);
    }

}
