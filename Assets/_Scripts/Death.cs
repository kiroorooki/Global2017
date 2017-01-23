using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using XInputDotNetPure;

public class Death : MonoBehaviour
{


    List<GameObject> BloodpatternList = new List<GameObject>();
    public GameObject Bloodpattern1;
    public GameObject Bloodpattern2;
    public GameObject Bloodpattern3;
    public GameObject Bloodpattern4;
    public GameObject Bloodpattern5;
    public GameObject Bloodpattern6;
    public AudioSource myAudiosource;
    public int playerGamepadId;
    public GameObject playerParent;

    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, .1f);
        BloodpatternList.Add(Bloodpattern1);
        BloodpatternList.Add(Bloodpattern2);
        BloodpatternList.Add(Bloodpattern3);
        BloodpatternList.Add(Bloodpattern4);
        BloodpatternList.Add(Bloodpattern5);
        BloodpatternList.Add(Bloodpattern6);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Camera.main.transform.DOShakePosition(1f, 0.5f, 20, 90);
            print(" ttuytutyu " + playerGamepadId + "momo");
            GameManager.singleton.playersScore[playerGamepadId] ++;
            int i = Random.Range(0, 1);
            SoundManager.singleton.Play(SoundManager.singleton.blood[i], 1, myAudiosource);
            Destroy(other.gameObject);
            int BloodpatternIndex = UnityEngine.Random.Range(0, 6);
            Instantiate(BloodpatternList[BloodpatternIndex], new Vector3(other.transform.position.x, 0.1f, other.transform.position.z), transform.rotation);
            GameManager.singleton.CheckEndGame(playerGamepadId);
        }

    }
}
