using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIGame : MonoBehaviour {

    public static UIGame singleton;

    void Awake()
    {
        singleton = this;
    }


    public List<Image> scoreP1 = new List<Image>();
    public List<Image> scoreP2 = new List<Image>();
    public List<Image> scoreP3 = new List<Image>();
    public List<Image> scoreP4 = new List<Image>();

    public GameObject MVP1;
    public GameObject MVP2;
    public GameObject MVP3;
    public GameObject MVP4;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
