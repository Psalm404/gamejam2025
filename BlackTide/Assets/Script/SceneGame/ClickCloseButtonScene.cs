using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCloseButtonScene : SceneGameBase
{
    int flag = 0;

    public override void StartPlay()
    {
        if (flag == 0)
        {
            MainGameManager.GetInstance().StartDialogSequence(9);
            flag = 1;
        }
    }

    public void OnButtonClick() {
        PlayAnimation();
        MainGameManager.GetInstance().SwitchState(GameState.Dialog);
    }

    public void PlayAnimation() { 
         //“Ù–ß£¨∆∆¡—
    }
}
