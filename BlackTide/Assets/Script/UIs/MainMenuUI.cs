using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public GameObject ConitnueButton;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("HasSave"))
        {
            ConitnueButton.SetActive(true);
        }
        else {
            ConitnueButton.SetActive(false);
        }
    }

    public void OnNewGame() {
        StartGame();
    }

    public void OnContinueGame()
    {
        SaveManager.GetInstance().Load();
        StartGame();
    }

    public void StartGame()
    {
        //test≈›≈›Ω· ¯
        // SceneGameManager.GetInstance().SetCurrentSceneID(22);
        // DialogManager.GetInstance().SetSequenceID(15);

        //∏ﬂ≥±
        SceneGameManager.GetInstance().SetCurrentSceneID(52);
        DialogManager.GetInstance().SetSequenceID(39);

        UIManager.GetInstance().CloseMainMenu();
        MainGameManager.GetInstance().LoadGame();
    }

    public void OnQuitGame()
    {
        Application.Quit();
    }
}
