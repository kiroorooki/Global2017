using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NinjaRotation : MonoBehaviour {

    public Transform starttransform;

	// Use this for initialization
	void Start () {
        SlowTurn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SlowTurn()
    {
        starttransform = transform;
        transform.DORotate(new Vector3(starttransform.rotation.x, starttransform.rotation.y + 720, starttransform.rotation.z), 20f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1).SetId("Slow");
    }

    public void RapidTurn()
    {
        //DOTween.Kill("Slow");
        starttransform = transform;
        transform.DORotate(new Vector3(starttransform.rotation.x, starttransform.rotation.y + 540, starttransform.rotation.z), 1f, RotateMode.FastBeyond360).SetId("Fast").OnComplete(SlowTurn);
    }
}
