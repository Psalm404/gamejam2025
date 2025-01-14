using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneGameManager : MonoBehaviour
{
    private static SceneGameManager Instance;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.LogError("Multiple instances of SceneGameManager found!");
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public static SceneGameManager GetInstance()
    {
        return Instance;
    }

    private int sceneID = 0;
    [SerializeField]
    private List<GameObject> sceneGames = new List<GameObject>();

    public void Load() { 
    
    }

    public void MoveOn()
    {
        sceneGames[sceneID].SetActive(false);
        sceneID++;
        sceneGames[sceneID].SetActive(true);
    }

    //todo
    public int GetSaveInfo()
    {
        return sceneID;
    }

    public void SetCurrentGameID(int id)
    {
        sceneID = id;
    }

    
}
