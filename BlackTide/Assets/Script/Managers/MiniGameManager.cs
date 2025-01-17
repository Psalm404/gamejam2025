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

    public void StartMiniGame()
    {
        if (currentMiniGame != null)
        {
            currentMiniGame.gameEnded -= OnMiniGameFinished;
            Destroy(currentMiniGame.gameObject);
        }
       
        if (currentGameID < miniGamePanelPrefab.Count)
        {
            GameObject miniGamePanel = Instantiate(miniGamePanelPrefab[currentGameID]);
            currentMiniGame = miniGamePanel.GetComponent<MiniGamePanel>();
        }
        else {
            MainGameManager.GetInstance().SwitchState(GameState.SceneGame);
        }
        
        Debug.Log(currentGameID);
      //  GameObject miniGamePanel = Instantiate(miniGamePanelPrefab[currentGameID]);
      //  currentMiniGame = miniGamePanel.GetComponent<MiniGamePanel>();


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
}
