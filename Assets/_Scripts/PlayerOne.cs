﻿using UnityEngine;
using System.Collections;

public class PlayerOne : MonoBehaviour {

	private float playerOneSpeed;
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
		if (Input.GetButtonDown ("SlowP1")) {
			playerOneSpeed = sneakySpeed;
			isSneaky = true;
		}
		if (Input.GetButtonUp ("SlowP1")) {
			playerOneSpeed = normalSpeed;
			isSneaky = false;
		}
		
        AttackP1();
        Projectiles();
		
	}
	
    void Projectiles()
    {
        // Projectiles
        if (Input.GetButton("ThrowP1"))
        {
            holdButtonTime += Time.deltaTime;
            holdButtonTime = Mathf.Clamp(holdButtonTime, 0f, timeToMax);
        }

        if (Input.GetButtonUp("ThrowP1"))
        {
            Vector3 direction = (new Vector3(Input.GetAxisRaw("ShootXP1"), 0, -Input.GetAxisRaw("ShootYP1"))) * (-1f);
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
    void AttackP1()
    {
		// Attaque
        if (Input.GetButtonDown("FireP1") && !AttackON)
        {
            AttackON = true;
            playerOneSpeed = 0;
            sneakySpeed = 0;
            Vector3 direction = (new Vector3(Input.GetAxisRaw("ShootXP1"), 0, -Input.GetAxisRaw("ShootYP1"))) * (-1f);
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
        playerOneSpeed = normalSpeed;
        sneakySpeed = playerOneSpeed;
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
