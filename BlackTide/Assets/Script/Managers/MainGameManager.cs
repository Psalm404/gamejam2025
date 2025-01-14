using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameState { SceneGame, Dialog, MiniGame, Animation }
public class MainGameManager : MonoBehaviour
{
    private static MainGameManager Instance;
    
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.LogError("Multiple instances of MainGameManager found!");
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public static MainGameManager GetInstance() {
        return Instance;
    }


    
    private GameState currentState = GameState.SceneGame;

    public void LoadGame() {
        if (currentState == GameState.Dialog)
        {
            DialogManager.GetInstance().NextDialog();
        }
        else if (currentState == GameState.MiniGame)
        {

        }
        else if (currentState == GameState.SceneGame) {
            SceneGameManager.GetInstance().Load();
            UIManager.GetInstance().ShowSceneGamePanel();
        }
    }


    public void SwitchState(GameState state)
    {
        if (state == GameState.Dialog)
        {
            currentState = GameState.Dialog;
            UIManager.GetInstance().ShowDialogPanel();
            UIManager.GetInstance().CloseMiniGamePanel();
            DialogManager.GetInstance().PlayNextDialogSequence();
        }
        else if (state == GameState.MiniGame)
        {
            currentState = GameState.MiniGame;
            UIManager.GetInstance().ShowMiniGamePanel();
            UIManager.GetInstance().CloseDialogPanel();
            MiniGameManager.GetInstance().StartMiniGame();
        }
        else if (state == GameState.SceneGame)
        {
            currentState = GameState.SceneGame;
            UIManager.GetInstance().CloseDialogPanel();
            UIManager.GetInstance().CloseMiniGamePanel();
            SceneGameManager.GetInstance().MoveOn();
        }
    }

    public void StartDialogSequence(int dialogSequenceID)
    {
        UIManager.GetInstance().ShowDialogPanel();
        DialogManager.GetInstance().PlayDialogSequence(dialogSequenceID);
    }


    public int GetSaveInfo()
    {
        return (int)currentState;
    }

    public void SetCurrentState(int state) {
        currentState = (GameState)state;
    }

}
