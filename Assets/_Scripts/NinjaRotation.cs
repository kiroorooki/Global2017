using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NinjaRotation : MonoBehaviour {

    public Transform starttransform;
    public int speed;
    public float timer;

	void Start () {
        speed = 45;
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * speed);
        if(speed == 360 && timer > 0)
        {
            timer -= Time.deltaTime;
        }else
        {
            speed = 45;
            timer = 0;
        }
    }

    public void RapidTurn()
    {
        speed = 360;
    }
}
