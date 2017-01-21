using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveBehav : MonoBehaviour {

    public float lifeTime;
    public float maxSize;
    public AnimationCurve SizeOverLifetime;
    public Gradient colorOverLifeTime;

    float timeAlive;
    Material my_Material;

	// Use this for initialization
	void Start ()
    {
		timeAlive = .8f;
        my_Material = GetComponent<MeshRenderer>().material;
        my_Material.color = colorOverLifeTime.Evaluate(timeAlive / lifeTime);
        transform.localScale = Vector3.one * maxSize * SizeOverLifetime.Evaluate(timeAlive / lifeTime);
        Destroy(this.gameObject, lifeTime);
	}
	
	// Update is called once per frame
	void Update ()
    {
        timeAlive += Time.deltaTime;
        my_Material.color = colorOverLifeTime.Evaluate(timeAlive / lifeTime);
        transform.localScale = Vector3.one * maxSize * SizeOverLifetime.Evaluate(timeAlive/lifeTime); 	
	}
}
