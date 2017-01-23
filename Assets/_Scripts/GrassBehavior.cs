using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassBehavior : MonoBehaviour
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
            GetComponent<Animator>().SetTrigger("Test");
            if (other.GetComponent<PlayerOne>())
            {
                Debug.Log("ToucheEau");
                other.GetComponent<PlayerOne>().isWalkingOnGrass = true;

            }

            if (other.GetComponent<PlayerTwo>())
            {
                Debug.Log("ToucheEau");
                other.GetComponent<PlayerTwo>().isWalkingOnGrass = true;

                if (other.GetComponent<PlayerThree>())
                {
                    Debug.Log("ToucheEau");
                    other.GetComponent<PlayerThree>().isWalkingOnGrass = true;
                }

                if (other.GetComponent<PlayerFour>())
                {
                    Debug.Log("ToucheEau");
                    other.GetComponent<PlayerFour>().isWalkingOnGrass = true;

                }


            }
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.GetComponent<PlayerOne>())
            {

                other.GetComponent<PlayerOne>().isWalkingOnGrass = false;
            }
                if (other.GetComponent<PlayerTwo>())
                {
                    
                    other.GetComponent<PlayerTwo>().isWalkingOnGrass = false;

                }

                if (other.GetComponent<PlayerThree>())
                {
                  
                    other.GetComponent<PlayerThree>().isWalkingOnGrass = false;

                }

                if (other.GetComponent<PlayerFour>())
                {
                   
                    other.GetComponent<PlayerFour>().isWalkingOnGrass = false;

                }
            }
        }
    }



