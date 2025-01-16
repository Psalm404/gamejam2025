using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private static SaveManager Instance;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.LogError("Multiple instances of SaveManager found!");
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public static SaveManager GetInstance()
    {
        return Instance;
    }

    public void Save() {
        int currentDialogSequence =DialogManager.GetInstance().GetSaveInfo();
        int currentMiniGame = MiniGameManager.GetInstance().GetSaveInfo();
        int currentSceneGame = SceneGameManager.GetInstance().GetSaveInfo();
        int currentState = MainGameManager.GetInstance().GetSaveInfo();
        PlayerPrefs.SetInt("HasSave", 1);
        PlayerPrefs.SetInt("Dialog", currentDialogSequence);
        PlayerPrefs.SetInt("MiniGame", currentMiniGame);
        PlayerPrefs.SetInt("SceneGame", currentSceneGame);
        PlayerPrefs.SetInt("State", currentState);
    }

    public void Load()
    {
        int currentDialogSequence = PlayerPrefs.GetInt("Dialog");
        int currentMiniGame = PlayerPrefs.GetInt("MiniGame");
        int currentSceneGame = PlayerPrefs.GetInt("SceneGame");
        int currentState = PlayerPrefs.GetInt("State");

        DialogManager.GetInstance().SetSequenceID(currentDialogSequence);
        MiniGameManager.GetInstance().SetCurrentGameID(currentMiniGame);
        SceneGameManager.GetInstance().SetCurrentSceneID(currentSceneGame);
        MainGameManager.GetInstance().SetCurrentState(currentState);
    }
}
