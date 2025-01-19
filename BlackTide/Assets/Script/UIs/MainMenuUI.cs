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
        AudioManager.GetInstance().clickUI.Play();
        StartGame();
    }

    public void OnContinueGame()
    {
        AudioManager.GetInstance().clickUI.Play();
        SaveManager.GetInstance().Load();
        StartGame();
    }

    public void StartGame()
    {
        //test第一章点击前
        // SceneGameManager.GetInstance().SetCurrentSceneID(16);
        // DialogManager.GetInstance().SetSequenceID(8);
        // MiniGameManager.GetInstance().SetCurrentGameID(7);

        //test泡泡
        //SceneGameManager.GetInstance().SetCurrentSceneID(21);
        //  DialogManager.GetInstance().SetSequenceID(15);
        // MiniGameManager.GetInstance().SetCurrentGameID(8);



        //test拍立得前过渡
          SceneGameManager.GetInstance().SetCurrentSceneID(35);
         DialogManager.GetInstance().SetSequenceID(28);
         MiniGameManager.GetInstance().SetCurrentGameID(12);


        //跨时空
        //SceneGameManager.GetInstance().SetCurrentSceneID(52);
        //DialogManager.GetInstance().SetSequenceID(39);
        //MiniGameManager.GetInstance().SetCurrentGameID(14);

        //高潮
        //SceneGameManager.GetInstance().SetCurrentSceneID(54);
        //DialogManager.GetInstance().SetSequenceID(39);

        UIManager.GetInstance().CloseMainMenu();
        MainGameManager.GetInstance().LoadGame();
    }

    public void OnQuitGame()
    {
        AudioManager.GetInstance().clickUI.Play();
        Application.Quit();
    }
}
