using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCloseButtonScene : SceneGameBase
{
    public void OnButtonClick() {
        PlayAnimation();
        MainGameManager.GetInstance().SwitchState(GameState.Dialog);
    }

    public void PlayAnimation() { 
         //“Ù–ß£¨∆∆¡—
    }
}
