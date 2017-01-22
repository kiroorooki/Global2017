using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;
using XInputDotNetPure;

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
	public bool playerOneReady = false;
	public bool playerTwoReady = false;
	public bool playerThreeReady = false;
	public bool playerFourReady = false;
	bool startGameUpdated = false;
	
	bool GameReady = false;

	GamePadState gamepad1;
	GamePadState gamepad2;
	GamePadState gamepad3;
	GamePadState gamepad4;
	GamePadState gamepad1_prev_state;
	GamePadState gamepad2_prev_state;
	GamePadState gamepad3_prev_state;
	GamePadState gamepad4_prev_state;

	PlayerIndex player1;
	PlayerIndex player2;
	PlayerIndex player3;
	PlayerIndex player4;

	void Awake() {
        DontDestroyOnLoad(GameManager);
    }

	void Start() {
		SoundManager.singleton.Play (SoundManager.singleton.musics [0], 1f, Camera.main.GetComponent<AudioSource> ());
		player1 = (PlayerIndex)0;
        gamepad1 = GamePad.GetState(player1);
        player2 = (PlayerIndex)1;
        gamepad2 = GamePad.GetState(player2);
        player3 = (PlayerIndex)2;
        gamepad3 = GamePad.GetState(player3);
        player4 = (PlayerIndex)3;
        gamepad4 = GamePad.GetState(player4);
	}

	void Update() {

		GameObject gameManager = GameObject.Find("GameManager");
		GameManager gameScript = gameManager.GetComponent<GameManager>();

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
				FindGamepad(0);
				gameScript.player1Play = true;
				SoundManager.singleton.Play (SoundManager.singleton.menu_start,1f,Camera.main.GetComponent<AudioSource> ());
				Debug.Log("Player 1 Ready !");
				WaitP1.SetActive(false);
				ReadyP1Text.SetActive(true);
				playerOneReady = true;
				playersReady = playersReady+1;
                ninjas[0].GetComponent<NinjaRotation>().RapidTurn();
                ninjas[0].GetComponent<NinjaRotation>().timer = 0.9f;
				GamePad.SetVibration(player1, 1f, 1f);
				Invoke("EndAllVibration", .2f);
            }
			if (Input.GetButtonDown("SubmitP2") && playerTwoReady == false) {
				FindGamepad(1);
				gameScript.player2Play = true;
				SoundManager.singleton.Play (SoundManager.singleton.menu_start,1f,Camera.main.GetComponent<AudioSource> ());
				Debug.Log("Player 2 Ready !");
				WaitP2.SetActive(false);
				ReadyP2Text.SetActive(true);
				playerTwoReady = true;
				playersReady = playersReady+1;
                ninjas[1].GetComponent<NinjaRotation>().RapidTurn();
                ninjas[1].GetComponent<NinjaRotation>().timer = 0.9f;
				GamePad.SetVibration(player2, 1f, 1f);
				Invoke("EndAllVibration", .2f);
            }
			if (Input.GetButtonDown("SubmitP3") && playerThreeReady == false) {
				FindGamepad(2);
				gameScript.player3Play = true;
				SoundManager.singleton.Play (SoundManager.singleton.menu_start,1f,Camera.main.GetComponent<AudioSource> ());
				Debug.Log("Player 3 Ready !");
				WaitP3.SetActive(false);
				ReadyP3Text.SetActive(true);
				playerThreeReady = true;
				playersReady = playersReady+1;
                ninjas[2].GetComponent<NinjaRotation>().RapidTurn();
                ninjas[2].GetComponent<NinjaRotation>().timer = 0.9f;
				GamePad.SetVibration(player3, 1f, 1f);
				Invoke("EndAllVibration", .2f);
            }
			if (Input.GetButtonDown("SubmitP4") && playerFourReady == false) {
				FindGamepad(3);
				gameScript.player4Play = true;
				SoundManager.singleton.Play (SoundManager.singleton.menu_start,1f,Camera.main.GetComponent<AudioSource> ());
				Debug.Log("Player 4 Ready !");
				WaitP4.SetActive(false);
				ReadyP4Text.SetActive(true);
				playerFourReady = true;
				playersReady = playersReady+1;
                ninjas[3].GetComponent<NinjaRotation>().RapidTurn();
                ninjas[3].GetComponent<NinjaRotation>().timer = 0.9f;
				GamePad.SetVibration(player4, 1f, 1f);
				Invoke("EndAllVibration", .2f);
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
		
		gamepad1_prev_state = gamepad1;
        gamepad2_prev_state = gamepad2;
        gamepad3_prev_state = gamepad3;
        gamepad4_prev_state = gamepad4;

        gamepad1 = GamePad.GetState(player1);
        gamepad2 = GamePad.GetState(player2);
        gamepad3 = GamePad.GetState(player3);
        gamepad4 = GamePad.GetState(player4);
	}

	public void NewGame() {
		SoundManager.singleton.Play (SoundManager.singleton.menu_select_menu_item,1f,Camera.main.GetComponent<AudioSource> ());
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
	
	void FindGamepad(int i)
    {
        PlayerIndex gamepadIndex = 0;

        if (gamepad1_prev_state.Buttons.Start == ButtonState.Released && gamepad1.Buttons.Start == ButtonState.Pressed)
        {
            gamepadIndex = (PlayerIndex)0;
            print("Gp 1 " + gamepadIndex);
        }
        if (gamepad2_prev_state.Buttons.Start == ButtonState.Released && gamepad2.Buttons.Start == ButtonState.Pressed)
        {
            gamepadIndex = (PlayerIndex)1;
            print("Gp 2 " + gamepadIndex);
        }
        if (gamepad3_prev_state.Buttons.Start == ButtonState.Released && gamepad3.Buttons.Start == ButtonState.Pressed)
        {
            gamepadIndex = (PlayerIndex)2;
            print("Gp 3 " + gamepadIndex);
        }
        if (gamepad4_prev_state.Buttons.Start == ButtonState.Released && gamepad4.Buttons.Start == ButtonState.Pressed)
        {
            gamepadIndex = (PlayerIndex)3;
            print("Gp 4 " + gamepadIndex);
        }

        if (i == 0)
        {
            player1 = gamepadIndex;
            print("P 1 :" + gamepadIndex);
        }
        else if(i == 1)
        {
            player2 = gamepadIndex;
            print("P 2 :" + gamepadIndex);
        }
        else if (i == 2)
        {
            player3 = gamepadIndex;
            print("P 3 :" + gamepadIndex);
        }
        else if (i == 3)
        {
            player4 = gamepadIndex;
            print("P 4 :" + gamepadIndex);
        }
    }
	
	
	
	void EndAllVibration(){
		GamePad.SetVibration(player1, 0f, 0f);
		GamePad.SetVibration(player2, 0f, 0f);
		GamePad.SetVibration(player3, 0f, 0f);
		GamePad.SetVibration(player4, 0f, 0f);
	}

}
