using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    
	public GameObject wave;
	public Gradient playeWaveGradientColor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter(Collision other) {
		Destroy (gameObject);
		GameObject newWave = Instantiate (wave, transform.position + new Vector3(0f,0f,0f), Quaternion.identity);
		newWave.GetComponent<WaveBehav> ().colorOverLifeTime = playeWaveGradientColor;
	}

}
