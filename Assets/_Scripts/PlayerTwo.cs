using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using XInputDotNetPure;

public class PlayerTwo : MonoBehaviour {

	private float playerSpeed;
	public float normalSpeed;
	public float sneakySpeed;
    public float deathVibrationTime;

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

	public bool isWalkingOnWood = false;
	public bool isWalkingOnWater = false;
	public bool isWalkingOnGrass = false;

	bool isWalking = false;

    Vector3 direction = Vector3.zero;

	AudioSource myAudioSource;
	SoundManager soundManager;
	WaitForSeconds walkWait = new WaitForSeconds(0.4f);
	WaitForSeconds walkWaitSneaky = new WaitForSeconds(1f);

	public GameObject wave;

	public Gradient playeWaveGradientColor;

	public GameObject SlashP2;

	void Start () {
		playerSpeed = normalSpeed;
		myAudioSource = GetComponent<AudioSource> ();
		soundManager = SoundManager.singleton;
	}

	void Awake() {
		controller = GetComponent<PlayerController> ();
	}

	void Update () {
		// Déplacement Normal
		Vector3 moveInput = new Vector3 (Input.GetAxisRaw ("HorizontalP2"), 0, Input.GetAxisRaw ("VerticalP2"));

		Vector3 moveVelocity = moveInput.normalized * playerSpeed;
		controller.Move (moveVelocity);    
		if ((Input.GetAxisRaw ("HorizontalP2") == 0 && Input.GetAxisRaw ("VerticalP2") == 0) && isWalking) {
			StopWalkSound ();
		} else if (!isWalking && (Input.GetAxisRaw ("HorizontalP2") != 0 || Input.GetAxisRaw ("VerticalP2") != 0) && !AttackON) {
			StartCoroutine ("Walk");
			isWalking = true;
		}


		// Déplacement Sneaky
		if (Input.GetButtonDown ("SlowP2") && AttackON == false) {
			playerSpeed = sneakySpeed;
			isSneaky = true;
		}
		if (Input.GetButtonUp ("SlowP2")) {
			playerSpeed = normalSpeed;
			isSneaky = false;
		}


		if(Input.GetAxisRaw("ShootXP2") != 0 || Input.GetAxisRaw("ShootYP2") != 0)
			direction = (new Vector3(Input.GetAxisRaw("ShootXP2"), 0, -Input.GetAxisRaw("ShootYP2"))) * (-1f);

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

			if (direction != Vector3.zero)
			{
				Projectile e = Instantiate(projectile, transform.position, Quaternion.identity);
				e.wave = wave;
				e.playeWaveGradientColor = playeWaveGradientColor;
				Physics.IgnoreCollision(e.GetComponent<Collider>(), GetComponent<Collider>());

				e.GetComponent<Rigidbody>().AddForce(direction * maxForce * holdButtonTime);

				holdButtonTime = 0f;
			}
		}
	}
	void AttackP2()
	{
		// Attaque
		if (Input.GetButtonDown("FireP2") && AttackON == false)
		{


			GameObject newWave = Instantiate (wave, transform.position + new Vector3(0f,0f,0f), Quaternion.identity);
			newWave.GetComponent<WaveBehav> ().colorOverLifeTime = playeWaveGradientColor;
			StopWalkSound ();
			AttackSound ();
			AttackON = true;
			playerSpeed = 0;
			isSneaky = false;

			AttackCone = Instantiate(Cone, transform.position, Quaternion.identity);
			AttackCone.transform.parent = transform;
			AttackCone.transform.LookAt(transform.position + direction);
			AttackCone.GetComponent<Death> ().myAudiosource = myAudioSource;
            AttackCone.GetComponent<Death>().playerGamepadId = 2;

            Physics.IgnoreCollision(AttackCone.GetComponent<Collider>(), GetComponent<Collider>());
			StartCoroutine(DelayAttack());
			MeshCollider ConeMesh = AttackCone.GetComponent<MeshCollider>();

			GameObject SlashEffect = Instantiate(SlashP2, AttackCone.transform.position + AttackCone.transform.forward, AttackCone.transform.rotation);
			SlashEffect.transform.parent = transform;
			SlashEffect.transform.LookAt(transform.position + direction*10f) ;
			Destroy(SlashEffect.gameObject, 1);
		}
	}

	IEnumerator DelayAttack()
	{
		yield return new WaitForSeconds(delay);
		playerSpeed = normalSpeed;
		Destroy(AttackCone);
		AttackON = false;
	}

	void OntriggerEnter(Collider other)
	{
		Debug.Log("Touche " + other);
		Destroy(other.gameObject);
	}

    void OnDestroy()
    {
        GamePad.SetVibration(GameManager.singleton.player2_index, 1f, 1f);
        GameManager.singleton.EndAllVibrationDelay(deathVibrationTime);
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
			if (!isSneaky || isWalkingOnWater) { // pop onde
				GameObject newWave = Instantiate (wave, transform.position + new Vector3(0f,0f,0f), Quaternion.identity);
				newWave.GetComponent<WaveBehav> ().colorOverLifeTime = playeWaveGradientColor;
			}
			if(!isSneaky) yield return walkWait;
			else yield return walkWaitSneaky;
		}

	}

	void StopWalkSound(){
		StopCoroutine ("Walk");
		isWalking = false;
	}



} 
