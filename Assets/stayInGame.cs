using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stayInGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}

    void OnLevelWasLoaded()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            Destroy(this.gameObject);
        }
    } 

}
