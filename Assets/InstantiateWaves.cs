using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateWaves : MonoBehaviour {

    public GameObject sphere;
    public int nbr;
    public float delay;
    public Vector3 instPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            StartCoroutine(DelayInstantiate(nbr, delay, instPos));
            Debug.Log("A pressed");
        }
	}

    IEnumerator DelayInstantiate(int nbr, float delay, Vector3 position)
    {
        int count = 0;
        while (count < nbr)
        {
            Instantiate(sphere, position, Quaternion.identity);
            count++;
            yield return new WaitForSeconds(delay);
        }
    }
}
