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
    private List<GameObject> miniGamePanelPrefab;

    public void StartMiniGame()
    {
        if (currentMiniGame != null)
        {
            currentMiniGame.gameEnded -= OnMiniGameFinished;
            Destroy(currentMiniGame.gameObject);
        }

        GameObject miniGamePanel = Instantiate(miniGamePanelPrefab[currentGameID]);
        currentMiniGame = miniGamePanel.GetComponent<MiniGamePanel>();

        if (currentMiniGame != null)
        {
            currentMiniGame.gameEnded += OnMiniGameFinished;
        }
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
