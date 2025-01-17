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
        sceneGames[0].SetActive(false);
        sceneGames[sceneID].SetActive(true);
        sceneGames[sceneID].GetComponent<SceneGameBase>().StartPlay();
    }

    public void MoveOn()
    {
        sceneGames[sceneID].SetActive(false);
        sceneID++;
        if (sceneID < sceneGames.Count) {
            sceneGames[sceneID].SetActive(true);
            sceneGames[sceneID].GetComponent<SceneGameBase>().StartPlay();
        }
    }

    public void StayCurrent() {
        sceneGames[sceneID].GetComponent<SceneGameBase>().StartPlay();
    }

    //todo
    public int GetSaveInfo()
    {
        return sceneID;
    }

    public void SetCurrentSceneID(int id)
    {
        sceneID = id;
    }

    
}
