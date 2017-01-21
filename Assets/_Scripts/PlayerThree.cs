using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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
	bool isSneaky = false;


	bool isWalkingOnWood = false;
	bool isWalkingOnWater = false;
	bool isWalkingOnGrass = false;

	bool isWalking = false;

	AudioSource myAudioSource;
	SoundManager soundManager;
	WaitForSeconds walkWait = new WaitForSeconds(0.4f);

    void Start () {
		playerThreeSpeed = normalSpeed;
		myAudioSource = GetComponent<AudioSource> ();
		soundManager = SoundManager.singleton;
	}

	void Awake() {
		controller = GetComponent<PlayerController> ();
	}

	void Update () {
		// Déplacement Normal
		Vector3 moveInput = new Vector3 (Input.GetAxisRaw ("HorizontalP3"), 0, Input.GetAxisRaw ("VerticalP3"));
		Vector3 moveVelocity = moveInput.normalized * playerThreeSpeed;
		controller.Move (moveVelocity);
		if ((Input.GetAxisRaw ("HorizontalP3") == 0 && Input.GetAxisRaw ("VerticalP3") == 0) && isWalking) {
			StopWalkSound ();
		} else if (!isWalking && (Input.GetAxisRaw ("HorizontalP3") != 0 || Input.GetAxisRaw ("VerticalP3") != 0) && !AttackON) {
			StartCoroutine ("Walk");
			isWalking = true;
		}

		// Déplacement Sneaky
		if (Input.GetButtonDown ("SlowP3")) {
			playerThreeSpeed = sneakySpeed;
			isSneaky = true;
		}
		if (Input.GetButtonUp ("SlowP3")) {
			playerThreeSpeed = normalSpeed;
			isSneaky = false;
		}
		
        AttackP3();
        Projectiles();
		
    }

    void Projectiles()
    {
        // Projectiles
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
    void AttackP3()
    {
		// Attaque
        if (Input.GetButtonDown("FireP3") && !AttackON) 
        {
            AttackON = true;
            playerThreeSpeed = 0;
            sneakySpeed = 0;
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
        Debug.Log("Touche " + other);
        //Instantiate (Blood, other.transform.position, other.transform.rotation)
        Destroy(other.gameObject);
    }


	void AttackSound(){
		int soundId;
		soundId = Random.Range (0, soundManager.bladeWoosh.Count - 1);
		soundManager.Play (soundManager.bladeWoosh [soundId], 1, myAudioSource);
	}

	IEnumerator Walk(){
		for (;;) {
			int soundId;
			List<AudioClip> walkSound;
			if (isWalkingOnWood)
				walkSound = soundManager.footStepWood;
			else if (isWalkingOnWater)
				walkSound = soundManager.footStepWater;
			else if (isWalkingOnGrass)
				walkSound = soundManager.footStepGrass;
			else
				walkSound = soundManager.footStepGround;
			soundId = Random.Range (0, walkSound.Count - 1);
			soundManager.Play (walkSound [soundId], 1, myAudioSource);
			yield return walkWait;
		}

	}

	void StopWalkSound(){
		StopCoroutine ("Walk");
		isWalking = false;
	}


}
