using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour {

	public GameObject MenuGroup;
	public GameObject NewGameGroup;
	public GameObject CreditsGroup;

	bool onNewGameMenu = false;
	bool playerOneReady = false;
	bool playerTwoReady = false;
	bool playerThreeReady = false;
	bool playerFourReady = false;


	void Update() {
		if (onNewGameMenu == true) {

		}
		if (onNewGameMenu == false) {
			playerOneReady = false;
			playerTwoReady = false;
			playerThreeReady = false;
			playerFourReady = false;
		}
	}

	public void NewGame() {
		onNewGameMenu = true;
		MenuGroup.SetActive(false);
		NewGameGroup.SetActive(true);
	}

	public void Credits() {
		MenuGroup.SetActive(false);
		CreditsGroup.SetActive(true);
	}

	public void Back() {
		onNewGameMenu = false;
		NewGameGroup.SetActive(false);
		CreditsGroup.SetActive(false);
		MenuGroup.SetActive(true);
	}

	public void Quit() {
		Application.Quit();
	}

}
