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

	public void NewGame() {
		MenuGroup.SetActive(false);
		NewGameGroup.SetActive(true);
	}

	public void Credits() {
		MenuGroup.SetActive(false);
		CreditsGroup.SetActive(true);
	}

	public void Back() {
		NewGameGroup.SetActive(false);
		CreditsGroup.SetActive(false);
		MenuGroup.SetActive(true);
	}

	public void Quit() {
		Application.Quit();
	}
}
