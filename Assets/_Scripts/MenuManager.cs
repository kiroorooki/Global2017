using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class MenuManager : MonoBehaviour {

	public GameObject MenuGroup;
	public GameObject NewGameGroup;
	public GameObject CreditsGroup;
	public GameObject NewGameBack;
	public GameObject CreditsBack;
	public GameObject NewGameButton;
	public GameObject StartGameButton;

    GameObject selectedbutton;
    int playersReady = 0;
	
	public GameObject ReadyP1Text;
	public GameObject ReadyP2Text;
	public GameObject ReadyP3Text;
	public GameObject ReadyP4Text;
	
	public GameObject WaitP1;
	public GameObject WaitP2;
	public GameObject WaitP3;
	public GameObject WaitP4;
	
	public GameObject GameManager;

    public List<GameObject> ninjas = new List<GameObject>();

	bool onNewGameMenu = false;
	bool playerOneReady = false;
	bool playerTwoReady = false;
	bool playerThreeReady = false;
	bool playerFourReady = false;
	bool startGameUpdated = false;
	
	bool GameReady = false;

	void Awake() {
        DontDestroyOnLoad(GameManager);
    }

	void Start() {
		SoundManager.singleton.Play (SoundManager.singleton.musics [0], 1f, Camera.main.GetComponent<AudioSource> ());
	}

	void Update() {

		if (onNewGameMenu == true) {
            foreach (GameObject ninja in ninjas)
            {
                if(ninja.activeSelf == false)
                    ninja.SetActive(true);
            }
			if (playersReady < 2) {
				Debug.Log("Not Enough Players !");
			} 
			if (playersReady >= 2) {
				Debug.Log("2 Players: You Can Start !");
				GameReady = true;
				if (startGameUpdated == false) {
					SelectButton (StartGameButton.transform.FindChild ("StartText").gameObject);
					startGameUpdated = true;
				}
			}
			if (Input.GetButtonDown("SubmitP1") && playerOneReady == false) {
				Debug.Log("Player 1 Ready !");
				WaitP1.SetActive(false);
				ReadyP1Text.SetActive(true);
				playerOneReady = true;
				playersReady = playersReady+1;
                ninjas[0].GetComponent<NinjaRotation>().RapidTurn();
			}
			if (Input.GetButtonDown("SubmitP2") && playerTwoReady == false) {
				Debug.Log("Player 2 Ready !");
				WaitP2.SetActive(false);
				ReadyP2Text.SetActive(true);
				playerTwoReady = true;
				playersReady = playersReady+1;
                ninjas[1].GetComponent<NinjaRotation>().RapidTurn();
            }
			if (Input.GetButtonDown("SubmitP3") && playerThreeReady == false) {
				Debug.Log("Player 3 Ready !");
				WaitP3.SetActive(false);
				ReadyP3Text.SetActive(true);
				playerThreeReady = true;
				playersReady = playersReady+1;
                ninjas[2].GetComponent<NinjaRotation>().RapidTurn();
            }
			if (Input.GetButtonDown("SubmitP4") && playerFourReady == false) {
				Debug.Log("Player 4 Ready !");
				WaitP4.SetActive(false);
				ReadyP4Text.SetActive(true);
				playerFourReady = true;
				playersReady = playersReady+1;
                ninjas[3].GetComponent<NinjaRotation>().RapidTurn();
            }
		}
		if (onNewGameMenu == false) {
            foreach (GameObject ninja in ninjas)
            {
                if(ninja.activeSelf == true)
                    ninja.SetActive(false);
            }
            playersReady = 0;
			startGameUpdated = false;
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
        UnselectButton(selectedbutton);
        selectedbutton = null;
        onNewGameMenu = true;
		MenuGroup.SetActive(false);
		NewGameGroup.SetActive(true);
		EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(StartGameButton);

	}
	
	public void StartGame() {
		if (GameReady == true) {
			Debug.Log("GO !");
			SceneManager.LoadScene("Main");
		}
	}

	public void Credits() {
        UnselectButton(selectedbutton);
        MenuGroup.SetActive(false);
		CreditsGroup.SetActive(true);
		EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(CreditsBack);
	}

	public void Back() {
		onNewGameMenu = false;
		GameReady = false;
		playersReady = 0;
        UnselectButton(selectedbutton);
		NewGameGroup.SetActive(false);
		CreditsGroup.SetActive(false);
		MenuGroup.SetActive(true);
		EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(NewGameButton);
	}

	public void Quit() {
		Application.Quit();
	}

    public void SelectButton(GameObject button)
    {
        selectedbutton = button;
        if (button.name != "StartText" || button.name == "StartText" && GameReady == true)
        {
            button.GetComponent<Text>().color = new Color(0.5f, 0, 0, 1);
            button.GetComponent<Transform>().transform.DOScale(1, 0.5f);
            //button.GetComponent<Transform>().transform.DORotate(new Vector3(0, 0, -10), 0.5f);
        } else {
            button.GetComponent<Text>().color = new Color(0.3f, 0.3f, 0.3f, 0.5f);
            button.GetComponent<Transform>().transform.DOScale(1, 0.5f);
        }
    }

    public void UnselectButton(GameObject button)
    {
        button.GetComponent<Text>().color = Color.black;
        button.GetComponent<Transform>().transform.DOScale(0.75f, 0.5f);
        //button.GetComponent<Transform>().transform.DORotate(new Vector3(0, 0, 0), 0.5f);
    }

}
