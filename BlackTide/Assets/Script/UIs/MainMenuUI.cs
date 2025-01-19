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
        //test��һ�µ��ǰ
         SceneGameManager.GetInstance().SetCurrentSceneID(16);
         DialogManager.GetInstance().SetSequenceID(8);
        MiniGameManager.GetInstance().SetCurrentGameID(7);

        //test���ݽ���
        // SceneGameManager.GetInstance().SetCurrentSceneID(22);
        // DialogManager.GetInstance().SetSequenceID(15);

        //�߳�
        //SceneGameManager.GetInstance().SetCurrentSceneID(52);
        //DialogManager.GetInstance().SetSequenceID(39);

        UIManager.GetInstance().CloseMainMenu();
        MainGameManager.GetInstance().LoadGame();
    }

    public void OnQuitGame()
    {
        Application.Quit();
    }
}
