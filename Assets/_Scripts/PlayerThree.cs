using UnityEngine;
using System.Collections;

public class PlayerThree : MonoBehaviour {

	private float playerThreeSpeed;
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
		playerThreeSpeed = normalSpeed;
	}

	void Awake() {
		controller = GetComponent<PlayerController> ();
	}

	void Update () {
		// Déplacement Normal
		Vector3 moveInput = new Vector3 (Input.GetAxisRaw ("HorizontalP3"), 0, Input.GetAxisRaw ("VerticalP3"));
		Vector3 moveVelocity = moveInput.normalized * playerThreeSpeed;
		controller.Move (moveVelocity);

		// Déplacement Sneaky
		if (Input.GetButtonDown ("SlowP3")) {
			playerThreeSpeed = sneakySpeed;
		}
		if (Input.GetButtonUp ("SlowP3")) {
			playerThreeSpeed = normalSpeed;
		}
        AttackP2();
        Projectiles();
    }

    void Projectiles()
    {
        // projectiles
        if (Input.GetButton("ThrowP3"))
        {
            holdButtonTime += Time.deltaTime;
            holdButtonTime = Mathf.Clamp(holdButtonTime, 0f, timeToMax);
        }

        if (Input.GetButtonUp("ThrowP3"))
        {
            Vector3 direction = (new Vector3(Input.GetAxisRaw("ShootXP3"), 0, -Input.GetAxisRaw("ShootYP3"))) * (-1f);
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
        if (Input.GetButtonDown("FireP3") && !AttackON) 
        {
            AttackON = true;
            print("FireP3");
            playerThreeSpeed = 0;
            sneakySpeed = 0;
            Debug.Log("Slash");
            Vector3 direction = (new Vector3(Input.GetAxisRaw("ShootXP3"), 0, -Input.GetAxisRaw("ShootYP3"))) * (-1f);
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
        playerThreeSpeed = normalSpeed;
        sneakySpeed = playerThreeSpeed;
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
