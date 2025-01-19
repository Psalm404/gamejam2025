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
        if (sceneGames[sceneID].GetComponent<SceneGameBase>() != null)
        {
            sceneGames[sceneID].GetComponent<SceneGameBase>().StartPlay();
        }
        if (sceneID == 18)
        {
            AudioManager.GetInstance().sinkInWater.Play();
        }else if (sceneID == 21) {//µÚÒ»·ù
            AudioManager.GetInstance().summer.Play();
        }
        else if (sceneID == 30)//¿§·ÈºÈ¾Æ
        {
            AudioManager.GetInstance().summer.Stop();
            AudioManager.GetInstance().coffeeBGM.Play();
        }
        else if (sceneID == 36)//3Ò¹Íí
        {
            AudioManager.GetInstance().coffeeBGM.Stop();
            AudioManager.GetInstance().nightSound.Play();
        }
        else if (sceneID == 43)//4ÐÇÐÇ
        {
            AudioManager.GetInstance().nightSound.Stop();
            AudioManager.GetInstance().starBGM.Play();
        }
        else if (sceneID == 49)//µÚÎå·ù
        {
            AudioManager.GetInstance().starBGM.Stop();
        }
    }

    public void MoveOn()
    {
        sceneGames[sceneID].SetActive(false);
        sceneID++;
        if (sceneID < sceneGames.Count) {
            sceneGames[sceneID].SetActive(true);
            if (sceneGames[sceneID].GetComponent<SceneGameBase>() != null) {
                sceneGames[sceneID].GetComponent<SceneGameBase>().StartPlay();
            }
            if (sceneID == 18) {
                AudioManager.GetInstance().sinkInWater.Play();
            }else if (sceneID == 21)
            {
                AudioManager.GetInstance().summer.Play();
            }
            else if (sceneID == 30)//¿§·ÈºÈ¾Æ
            {
                AudioManager.GetInstance().summer.Stop();
                AudioManager.GetInstance().coffeeBGM.Play();
            }
            else if (sceneID == 36)//3Ò¹Íí
            {
                AudioManager.GetInstance().coffeeBGM.Stop();
                AudioManager.GetInstance().nightSound.Play();
            }
            else if (sceneID == 43)//4ÐÇÐÇ
            {
                AudioManager.GetInstance().nightSound.Stop();
                AudioManager.GetInstance().starBGM.Play();
            }
            else if (sceneID == 49)//µÚÎå·ù
            {
                AudioManager.GetInstance().starBGM.Stop();
            }
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
