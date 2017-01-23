﻿using System.Collections;
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

	public GameManager gameManager;

    public List<GameObject> ninjas = new List<GameObject>();

	bool onNewGameMenu = false;
	public bool playerOneReady = false;
	public bool playerTwoReady = false;
	public bool playerThreeReady = false;
	public bool playerFourReady = false;
	bool startGameUpdated = false;
	
	bool GameReady = false;

    public GamePadState gamepad1;
    public GamePadState gamepad2;
    public GamePadState gamepad3;
    public GamePadState gamepad4;
    public GamePadState gamepad1_prev_state;
    public GamePadState gamepad2_prev_state;
    public GamePadState gamepad3_prev_state;
    public GamePadState gamepad4_prev_state;

    PlayerIndex player1_index;
    PlayerIndex player2_index;
    PlayerIndex player3_index;
    PlayerIndex player4_index;

    void Awake() {
        
    }

	void Start() {
        gamepad1 = GamePad.GetState((PlayerIndex)1);
        gamepad2 = GamePad.GetState((PlayerIndex)2);
        gamepad3 = GamePad.GetState((PlayerIndex)3);
        gamepad4 = GamePad.GetState((PlayerIndex)4);
        player1_index = (PlayerIndex)1;
        player2_index = (PlayerIndex)2;
        player3_index = (PlayerIndex)3;
        player4_index = (PlayerIndex)4;
        global::GameManager.singleton.player1_index = player1_index;
        global::GameManager.singleton.player2_index = player2_index;
        global::GameManager.singleton.player3_index = player3_index;
        global::GameManager.singleton.player4_index = player4_index;
        gameManager = GameManager.singleton;
        SoundManager.singleton.Play (SoundManager.singleton.musics[0], 1f, Camera.main.GetComponent<AudioSource> ());
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

            if (Input.GetButtonDown("SubmitP1") && playerOneReady == false /*&&  (gamepad1.Buttons.Start == ButtonState.Pressed || gamepad2.Buttons.Start == ButtonState.Pressed || gamepad3.Buttons.Start == ButtonState.Pressed || gamepad4.Buttons.Start == ButtonState.Pressed) */ ) {
                gameManager.player1Play = true;
				SoundManager.singleton.Play (SoundManager.singleton.menu_start,1f,Camera.main.GetComponent<AudioSource> ());
				Debug.Log("Player 1 Ready !");
				WaitP1.SetActive(false);
				ReadyP1Text.SetActive(true);
				playerOneReady = true;
				playersReady = playersReady+1;
                ninjas[0].GetComponent<NinjaRotation>().RapidTurn();
                ninjas[0].GetComponent<NinjaRotation>().timer = 0.9f;
				Invoke("EndAllVibration", .2f);
            }

            if (Input.GetButtonDown("SubmitP2") && playerTwoReady == false /*&& (gamepad1.Buttons.Start == ButtonState.Pressed || gamepad2.Buttons.Start == ButtonState.Pressed || gamepad3.Buttons.Start == ButtonState.Pressed || gamepad4.Buttons.Start == ButtonState.Pressed)*/)
            {
                gameManager.player2Play = true;
				SoundManager.singleton.Play (SoundManager.singleton.menu_start,1f,Camera.main.GetComponent<AudioSource> ());
				Debug.Log("Player 2 Ready !");
				WaitP2.SetActive(false);
				ReadyP2Text.SetActive(true);
				playerTwoReady = true;
				playersReady = playersReady+1;
                ninjas[1].GetComponent<NinjaRotation>().RapidTurn();
                ninjas[1].GetComponent<NinjaRotation>().timer = 0.9f;
				Invoke("EndAllVibration", .2f);
            }

            if (Input.GetButtonDown("SubmitP3") && playerThreeReady == false /*&& (gamepad1.Buttons.Start == ButtonState.Pressed || gamepad2.Buttons.Start == ButtonState.Pressed || gamepad3.Buttons.Start == ButtonState.Pressed || gamepad4.Buttons.Start == ButtonState.Pressed)*/)
            {
                gameManager.player3Play = true;
				SoundManager.singleton.Play (SoundManager.singleton.menu_start,1f,Camera.main.GetComponent<AudioSource> ());
				Debug.Log("Player 3 Ready !");
				WaitP3.SetActive(false);
				ReadyP3Text.SetActive(true);
				playerThreeReady = true;
				playersReady = playersReady+1;
                ninjas[2].GetComponent<NinjaRotation>().RapidTurn();
                ninjas[2].GetComponent<NinjaRotation>().timer = 0.9f;
				Invoke("EndAllVibration", .2f);
            }

			if (Input.GetButtonDown("SubmitP4") && playerFourReady == false /*&& (gamepad1.Buttons.Start == ButtonState.Pressed || gamepad2.Buttons.Start == ButtonState.Pressed || gamepad3.Buttons.Start == ButtonState.Pressed || gamepad4.Buttons.Start == ButtonState.Pressed)*/)
            {
                gameManager.player4Play = true;
				SoundManager.singleton.Play (SoundManager.singleton.menu_start,1f,Camera.main.GetComponent<AudioSource> ());
				Debug.Log("Player 4 Ready !");
				WaitP4.SetActive(false);
				ReadyP4Text.SetActive(true);
				playerFourReady = true;
				playersReady = playersReady+1;
                ninjas[3].GetComponent<NinjaRotation>().RapidTurn();
                ninjas[3].GetComponent<NinjaRotation>().timer = 0.9f;
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
        gameManager.playersNumber = playersReady;

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

    /*
    public void FindGamepad(int i)
    {
        PlayerIndex gamepadIndex = (PlayerIndex)0;
        GameManager gm = global::GameManager.singleton;
        if (gamepad1.Buttons.Start == ButtonState.Pressed)
        {
            
        }
        if (gamepad2.Buttons.Start == ButtonState.Pressed)
        {
            
        }
        if (gamepad3.Buttons.Start == ButtonState.Pressed)
        {
            gamepadIndex = (PlayerIndex)2;
        }
        if (gamepad4.Buttons.Start == ButtonState.Pressed)
        {
            gamepadIndex = (PlayerIndex)3;
        }

        if (i == 0)
        {
            gamepadIndex = (PlayerIndex)0;
            player1_index = gamepadIndex;
            global::GameManager.singleton.player1_index = gamepadIndex;
        }
        else if (i == 1)
        {
            player2_index = gamepadIndex;
            gamepadIndex = (PlayerIndex)1;
            global::GameManager.singleton.player2_index = gamepadIndex;
        }
        else if (i == 2)
        {
            player3_index = gamepadIndex;
            global::GameManager.singleton.player3_index = gamepadIndex;
        }
        else if (i == 3)
        {
            player4_index = gamepadIndex;
            global::GameManager.singleton.player4_index = gamepadIndex;
        }
    }
    */
    public void EndAllVibrationDelay(float delay)
    {
        Invoke("EndAllVibration", delay);
    }

    public void EndAllVibration()
    {
        GamePad.SetVibration(player1_index, 0f, 0f);
        GamePad.SetVibration(player2_index, 0f, 0f);
        GamePad.SetVibration(player3_index, 0f, 0f);
        GamePad.SetVibration(player4_index, 0f, 0f);
    }

}
