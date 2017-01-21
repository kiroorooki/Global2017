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
	public GameObject NewGameBack;
	public GameObject CreditsBack;
	public GameObject NewGameButton;
	public GameObject StartGameText;
	
	public GameObject ReadyP1Text;
	public GameObject ReadyP2Text;
	public GameObject ReadyP3Text;
	public GameObject ReadyP4Text;
	
	public GameObject WaitP1;
	public GameObject WaitP2;
	public GameObject WaitP3;
	public GameObject WaitP4;
	
	public GameObject GameManager;

	bool onNewGameMenu = false;
	bool playerOneReady = false;
	bool playerTwoReady = false;
	bool playerThreeReady = false;
	bool playerFourReady = false;
	
	bool GameReady = false;

	void Awake() {
        DontDestroyOnLoad(GameManager);
    }
	
	void Update() {
		if (onNewGameMenu == true) {
			if (playerOneReady == false && playerTwoReady == false) {
				Debug.Log("Not Enough Players !");
				StartGameText.SetActive(false);
			} 
			if (playerOneReady == true && playerTwoReady == true || playerThreeReady == true || playerFourReady == true) {
				Debug.Log("2 Players: You Can Start !");
				StartGameText.SetActive(true);
				GameReady = true;
			}
			if (Input.GetButtonDown("Submit")) {
				Debug.Log("Player 1 Ready !");
				WaitP1.SetActive(false);
				ReadyP1Text.SetActive(true);
				playerOneReady = true;
			}
			if (Input.GetButtonDown("SubmitP2")) {
				Debug.Log("Player 2 Ready !");
				WaitP2.SetActive(false);
				ReadyP2Text.SetActive(true);
				playerTwoReady = true;
			}
			if (Input.GetButtonDown("SubmitP3")) {
				Debug.Log("Player 3 Ready !");
				WaitP3.SetActive(false);
				ReadyP3Text.SetActive(true);
				playerThreeReady = true;
			}
			if (Input.GetButtonDown("SubmitP4")) {
				Debug.Log("Player 4 Ready !");
				WaitP4.SetActive(false);
				ReadyP4Text.SetActive(true);
				playerFourReady = true;
			}
			if (GameReady == true && Input.GetButtonDown("Start")) {
				Debug.Log("GO !");
				Application.LoadLevel("Main");
			}
		}
		if (onNewGameMenu == false) {
			playerOneReady = false;
			playerTwoReady = false;
			playerThreeReady = false;
			playerFourReady = false;
			ReadyP1Text.SetActive(false);
			ReadyP2Text.SetActive(false);
			ReadyP3Text.SetActive(false);
			ReadyP4Text.SetActive(false);
			WaitP1.SetActive(true);
			WaitP2.SetActive(true);
			WaitP3.SetActive(true);
			WaitP4.SetActive(true);
		}
	}

	public void NewGame() {
		onNewGameMenu = true;
		MenuGroup.SetActive(false);
		NewGameGroup.SetActive(true);
		EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(NewGameBack);
	}

	public void Credits() {
		MenuGroup.SetActive(false);
		CreditsGroup.SetActive(true);
		EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(CreditsBack);
	}

	public void Back() {
		onNewGameMenu = false;
		NewGameGroup.SetActive(false);
		CreditsGroup.SetActive(false);
		MenuGroup.SetActive(true);
		EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(NewGameButton);
	}

	public void Quit() {
		Application.Quit();
	}

}
