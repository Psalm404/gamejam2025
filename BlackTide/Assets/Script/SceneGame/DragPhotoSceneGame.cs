using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragPhotoSceneGame : SceneGameBase
{
    [SerializeField]
    private List<GameObject> phototList = new List<GameObject>();

    private int current = 0;

    public override void StartPlay()
    {
        base.StartPlay();
        phototList[0].SetActive(true);
    }

    public void NextPhoto() {
        phototList[current].SetActive(false);
        current++;
        if (current >= phototList.Count)
        {
            MainGameManager.GetInstance().SwitchState(GameState.SceneGame);
            //todo audio stop
        }
        else {
            phototList[current].SetActive(true);
        }
    }
}
