using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {


    List<GameObject> BloodpatternList = new List<GameObject>();
    public GameObject Bloodpattern1;
    public GameObject Bloodpattern2;
    public GameObject Bloodpattern3;
    public GameObject Bloodpattern4;
    public GameObject Bloodpattern5;
    public GameObject Bloodpattern6;

    // Use this for initialization
    void Start () {
        BloodpatternList.Add(Bloodpattern1);
        BloodpatternList.Add(Bloodpattern2);
        BloodpatternList.Add(Bloodpattern3);
        BloodpatternList.Add(Bloodpattern4);
        BloodpatternList.Add(Bloodpattern5);
        BloodpatternList.Add(Bloodpattern6);

       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter (Collider other)
    {
        Debug.Log("Touche");
		if (other.tag == "Player") 
		{
			Destroy (other.gameObject);
            int BloodpatternIndex = UnityEngine.Random.Range(0, 6);
            Instantiate(BloodpatternList[BloodpatternIndex], new Vector3( other.transform.position.x,0.1f,other.transform.position.z),transform.rotation);

		}
    }
}
