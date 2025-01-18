using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameManager : MonoBehaviour
{
    private static MiniGameManager Instance;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.LogError("Multiple instances of MiniGameManager found!");
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

       
    }
    public static MiniGameManager GetInstance()
    {
        return Instance;
    }


    private int currentGameID = 0;
    private MiniGamePanel currentMiniGame;
    [SerializeField]
    private List<GameObject> miniGamePanelPrefab = new List<GameObject>();
    [SerializeField]
    private List<GameObject> miniGames = new List<GameObject>();

    public void StartMiniGame()

    {
        Debug.Log("startminigame");

        if (currentMiniGame != null)
        {
            currentMiniGame.gameEnded -= OnMiniGameFinished;
            Destroy(currentMiniGame.gameObject);
        }
       
        if (currentGameID < miniGamePanelPrefab.Count)
        {
            GameObject minigame = miniGames[currentGameID];
            if (minigame != null)
            {
                Debug.Log("findminigame" + minigame.name);
                minigame.SetActive(true);
            }
            else
            {
                Debug.LogWarning("minigame object not found in the scene.");
            }
        }
        else {
            MainGameManager.GetInstance().SwitchState(GameState.SceneGame);
        }
        
        Debug.Log(currentGameID);


        if (currentMiniGame != null)
        {
            currentMiniGame.gameEnded += OnMiniGameFinished;
        }
    }

    public void LoadGame()
    {
        //
    }

    private void OnMiniGameFinished()
    {
        currentMiniGame.gameEnded -= OnMiniGameFinished;
        Destroy(currentMiniGame.gameObject);
        currentMiniGame = null;
        currentGameID++;


    }


    public int GetSaveInfo()
    {
        return currentGameID;
    }

    public void SetCurrentGameID(int id)
    {
        currentGameID = id;
    }

    public void FinishMinigame(string minigameName) {
       
       
        GameObject minigame = miniGames[currentGameID];
        Debug.Log(minigame.name + "isfinished");
        if (minigame != null)
        {
            minigame.SetActive(false);
            currentGameID++;
        }
        else
        {
            Debug.LogWarning("minigame object not found in the scene." + minigameName);
        }

        MainGameManager.GetInstance().SwitchState(GameState.SceneGame);

    }

}
