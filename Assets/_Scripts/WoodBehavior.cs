using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodBehavior : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.GetComponent<PlayerOne>())
            {
                Debug.Log("ToucheEau");
                other.GetComponent<PlayerOne>().isWalkingOnWood = true;

            }

            if (other.GetComponent<PlayerTwo>())
            {
                Debug.Log("ToucheEau");
                other.GetComponent<PlayerTwo>().isWalkingOnWood = true;
            }

            if (other.GetComponent<PlayerThree>())
            {
                Debug.Log("ToucheEau");
                other.GetComponent<PlayerThree>().isWalkingOnWood = true;
            }

            if (other.GetComponent<PlayerFour>())
            {
                Debug.Log("ToucheEau");
                other.GetComponent<PlayerFour>().isWalkingOnWood = true;

            }



        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.GetComponent<PlayerOne>())
            {
                Debug.Log("ToucheEau");
                other.GetComponent<PlayerOne>().isWalkingOnWood = false;
            }
            if (other.GetComponent<PlayerTwo>())
            {
                Debug.Log("ToucheEau");
                other.GetComponent<PlayerTwo>().isWalkingOnWood = false;

            }

            if (other.GetComponent<PlayerThree>())
            {
                Debug.Log("ToucheEau");
                other.GetComponent<PlayerThree>().isWalkingOnWood = false;

            }

            if (other.GetComponent<PlayerFour>())
            {
                Debug.Log("ToucheEau");
                other.GetComponent<PlayerFour>().isWalkingOnWood = false;

            }
        }
    }
}
