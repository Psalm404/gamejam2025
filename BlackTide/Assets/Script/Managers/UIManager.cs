using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.LogError("Multiple instances of UIManager found!");
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public static UIManager GetInstance()
    {
        return Instance;
    }

    [SerializeField]
    private GameObject MainMenuUI;
    [SerializeField]
    private GameObject MiniGameUI;
    [SerializeField]
    private GameObject DialogUI;
    [SerializeField]
    private GameObject SceneGameUI;


    private void Start()
    {
        CloseAll();
        ShowMainMenu();
    }

    private void CloseAll() {
        MainMenuUI.SetActive(false);
        MiniGameUI.SetActive(false);
        DialogUI.SetActive(false);
        SceneGameUI.SetActive(false);
    }

    public void ShowMainMenu() {
        MainMenuUI.SetActive(true);
    }

    public void CloseMainMenu()
    {
        MainMenuUI.SetActive(false);
    }

    public void ShowDialogPanel() {
        DialogUI.SetActive(true);
    }

    public void CloseDialogPanel()
    {
        DialogUI.SetActive(false);
    }

    public void ShowMiniGamePanel()
    {
        MiniGameUI.SetActive(true);
    }

    public void CloseMiniGamePanel()
    {
        MiniGameUI.SetActive(false);
    }

    public void ShowSceneGamePanel()
    {
        SceneGameUI.SetActive(true);
    }

    public void CloseSceneGamePanel()
    {
        SceneGameUI.SetActive(false);
    }
}
