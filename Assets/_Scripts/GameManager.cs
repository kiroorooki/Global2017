using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;
using XInputDotNetPure;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton;

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public bool player1Play = false;
    public bool player2Play = false;
    public bool player3Play = false;
    public bool player4Play = false;


    private PlayerOne P1;
    private PlayerTwo P2;
    private PlayerThree P3;
    private PlayerFour P4;

    public GameObject Fumigene;

    bool playersSpawn = false;
    public float timer = 1f;

    public PlayerIndex player1_index;
    public PlayerIndex player2_index;
    public PlayerIndex player3_index;
    public PlayerIndex player4_index;

    public int playersNumber;
    public int[] playersScore;

    public bool gameOn;

    /*
    public GameObject endRound;
    public GameObject endGame;
    Text ERText;
    Text EGText;
    */

    public GameObject uiGame;

    bool GameStarted = false;

    bool isEndGame = false;
    public int maxScore;
    int winner = 0;

    void Awake()
    {
        singleton = this;
        DontDestroyOnLoad(this);
    }

    // Use this for initialization
    void Start()
    {
        gameOn = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }



    void OnEnable()
    {

    }

    bool notDone = true;

    public float reloadGameTime;

    void Update()
    {
        if (playersSpawn == false && SceneManager.GetActiveScene().name == "Main")
        {

            
            if (!gameOn)
            {
                /*
                endRound = GameObject.Find("RoundEndText");
                endGame = GameObject.Find("GameEndText");
                if (endRound != null)
                {
                    ERText = endRound.GetComponent<Text>();
                    endRound.SetActive(false);
                }
                if (endGame != null)
                {
                    EGText = endGame.GetComponent<Text>();
                    endGame.SetActive(false);
                }
                */
                uiGame = GameObject.Find("PlayerKills");
                uiGame.SetActive(false);
                gameOn = true;
            }
            

            SoundManager.singleton.Play(SoundManager.singleton.musics[0], 1f, Camera.main.GetComponent<AudioSource>());
            if (!GameStarted)
            {
                StartCoroutine("ActivatePlayer");
                GameStarted = true;
            }
            playersSpawn = true;
            isEndGame = false;

        }
        else if (SceneManager.GetActiveScene().name == "Main")
        {

        }

    }

    IEnumerator ActivatePlayer()
    {

        yield return null;
        if (player1Play == true)
        {
            P1 = Instantiate(player1, new Vector3(-20f, 1.5f, 0f), player1.transform.rotation).GetComponent<PlayerOne>();
            P1.enabled = false;
        }
        if (player2Play == true)
        {
            P2 = Instantiate(player2, new Vector3(20f, 1.5f, 0f), player2.transform.rotation).GetComponent<PlayerTwo>();
            P2.enabled = false;
        }
        if (player3Play == true)
        {
            P3 = Instantiate(player3, new Vector3(0f, 1.5f, -12f), player3.transform.rotation).GetComponent<PlayerThree>();
            P3.enabled = false;
        }
        if (player4Play == true)
        {
            P4 = Instantiate(player4, new Vector3(0f, 1.5f, 12f), player4.transform.rotation).GetComponent<PlayerFour>();
            P4.enabled = false;
        }

        yield return new WaitForSeconds(3.9f);
        //disparait
        if (P1)
        {
            GameObject e = Instantiate(Fumigene, P1.transform.position, Fumigene.transform.rotation);
            Destroy(e, 1.5f);
            P1.transform.GetChild(0).gameObject.SetActive(false);
            P1.enabled = true;
        }
        if (P2)
        {
            GameObject e = Instantiate(Fumigene, P2.transform.position, Fumigene.transform.rotation);
            Destroy(e, 1.5f);
            P2.transform.GetChild(0).gameObject.SetActive(false);
            P2.enabled = true;
        }
        if (P3)
        {
            GameObject e = Instantiate(Fumigene, P3.transform.position, Fumigene.transform.rotation);
            Destroy(e, 1.5f);
            P3.transform.GetChild(0).gameObject.SetActive(false);
            P3.enabled = true;
        }
        if (P4)
        {
            GameObject e = Instantiate(Fumigene, P4.transform.position, Fumigene.transform.rotation);
            Destroy(e,1.5f);
            P4.transform.GetChild(0).gameObject.SetActive(false);
            P4.enabled = true;
        }
        EndAllVibrationDelay(.1f);
    }

    public void EndAllVibrationDelay(float delay)
    {
        Invoke("EndAllVibration", delay);
    }

    public void EndAllVibration()
    {
        /*
        GamePad.SetVibration(player1_index, 0f, 0f);
        GamePad.SetVibration(player2_index, 0f, 0f);
        GamePad.SetVibration(player3_index, 0f, 0f);
        GamePad.SetVibration(player4_index, 0f, 0f);
        */
    }

    public void CheckEndGame(int playerID)
    {
        winner = playerID;
            Invoke("EndGame", 2f);
    }

    public void EndGame()
    {
        UIGame ui = uiGame.GetComponent<UIGame>();
        int endGameWinner = 5;
        if (GameObject.FindGameObjectsWithTag("Player").Length == 1)
        {
            for (int i = 0; i < 5; i++)
            {
                if (playersScore[i] >= maxScore)
                {
                    isEndGame = true;
                    endGameWinner = i;
                }
            }
            int playerID = winner;
            //fin du jeu
            if (!isEndGame)
            {
                /*
                if (playerID == 1)
                {
                    //ERText.text = "Player one wins the round ! \n score : " + playersScore[1];
                }
                else if (playerID == 2)
                {
                    //ERText.text = "Player two wins the round ! \n score : " + playersScore[2];
                }
                else if (playerID == 3)
                {
                    //ERText.text = "Player three wins the round ! \n score : " + playersScore[3];
                }
                else if (playerID == 4)
                {
                    //ERText.text = "Player four wins the round ! \n score : " + playersScore[4];
                }
                */
                
                for (int j = 0; j < Mathf.Clamp(playersScore[1], 0, 10); j++)
                    {
                        ui.scoreP1[j].color = new Color(1,1,1,1);
                    }
                for (int j = 0; j < Mathf.Clamp(playersScore[2], 0, 10); j++)
                {
                    ui.scoreP2[j].color = new Color(1, 1, 1, 1);
                }
                for (int j = 0; j < Mathf.Clamp(playersScore[3], 0, 10); j++)
                {
                    ui.scoreP3[j].color = new Color(1, 1, 1, 1);
                }
                for (int j = 0; j < Mathf.Clamp(playersScore[4], 0, 10); j++)
                {
                    ui.scoreP4[j].color = new Color(1, 1, 1, 1);
                }


                //endRound.SetActive(true);
                uiGame.SetActive(true);
                Invoke("ReloadGame", reloadGameTime);
            }
            else
            {
                /*
                if (playerID == 1)
                {
                    //EGText.text = "Player one wins the game ! \n score : " + playersScore[1];
                }
                else if (playerID == 2)
                {
                    //EGText.text = "Player two wins the game ! \n score : " + playersScore[2];
                }
                else if (playerID == 3)
                {
                    //EGText.text = "Player three wins the game ! \n score : " + playersScore[3];
                }
                else if (playerID == 4)
                {
                    //EGText.text = "Player four wins the game ! \n score : " + playersScore[4];
                }
                */
                for (int j = 0; j < Mathf.Clamp(playersScore[1], 0, 10); j++)
                {
                    ui.scoreP1[j].color = new Color(1, 1, 1, 1);
                }
                for (int j = 0; j < Mathf.Clamp(playersScore[2], 0, 10); j++)
                {
                    ui.scoreP2[j].color = new Color(1, 1, 1, 1);
                }
                for (int j = 0; j < Mathf.Clamp(playersScore[3], 0, 10); j++)
                {
                    ui.scoreP3[j].color = new Color(1, 1, 1, 1);
                }
                for (int j = 0; j < Mathf.Clamp(playersScore[4], 0, 10); j++)
                {
                    ui.scoreP4[j].color = new Color(1, 1, 1, 1);
                }
                //endGame.SetActive(true);
                uiGame.SetActive(true);
                Invoke("ReloadGameResetScores", reloadGameTime);
            }
        }
    }

    void ReloadGameResetScores()
    {
        playersSpawn = false;
        GameStarted = false;
        uiGame.SetActive(false);
        //endRound.SetActive(false);
        //endGame.SetActive(false);
        for (int i = 0; i < 5; i++)
        {
            playersScore[i] = 0;
        }
        gameOn = false;

        Destroy(gameObject);
        SceneManager.LoadScene("Menu");
        SceneManager.UnloadSceneAsync("Main");

    }

    void ReloadGame()
    {
        gameOn = false;
        GameStarted = false;
        playersSpawn = false;
        uiGame.SetActive(false);
        //endGame.SetActive(false);
        //endRound.SetActive(false);
        SceneManager.LoadScene("Main");
    }

    void OnDestroy()
    {
        EndAllVibration();
    }


}
