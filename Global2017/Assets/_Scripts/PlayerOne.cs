using UnityEngine;
using System.Collections;

public class PlayerOne : MonoBehaviour {

	private float playerOneSpeed;
	public float normalSpeed;
	public float sneakySpeed;
    public float KatanaRange;
    public float KatanaAngle;
    public GameObject Cone;
    public float delay;
    private GameObject AttackCone;
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

		// Déplacement Sneaky
		if (Input.GetButtonDown ("Slow")) {
			playerOneSpeed = sneakySpeed;
		}
		if (Input.GetButtonUp ("Slow")) {
			playerOneSpeed = normalSpeed;
		}

        Attack();
	}

    void Attack ()
    {
        if(Input.GetButtonDown("Fire3"))
        {
            playerOneSpeed = 0;
            sneakySpeed = 0;
            Debug.Log("Slash");
           AttackCone = (GameObject) Instantiate (Cone, transform.position, transform.rotation);
            Physics.IgnoreCollision(AttackCone.GetComponent<Collider>(), GetComponent<Collider>());
            StartCoroutine(DelayAttack());
           MeshCollider ConeMesh = AttackCone.GetComponent<MeshCollider>();
           /* Mesh NewCone = new Mesh();
            NewCone = new Mesh();
            NewCone.vertices = KatanaRange;
            */
            //ConeMesh.sharedMesh = new Mesh();

           // MeshCollider ConeRange = (MeshCollider)AttackCone.GetComponent<Collider>();
            // ConeRange.size
        }
    }

    IEnumerator DelayAttack ()
    {
        yield return new WaitForSeconds(delay);
        playerOneSpeed = normalSpeed;
        sneakySpeed = playerOneSpeed;
        Destroy(AttackCone);
    }

    void OntriggerEnter( Collider other)
    {
        Debug.Log("Touche");
        //Instantiate (Blood, other.transform.position, other.transform.rotataion)
        Destroy(other.gameObject);
    }

} 
