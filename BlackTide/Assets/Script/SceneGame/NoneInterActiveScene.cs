using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoneInteractiveScene : SceneGameBase
{
    public GameState nextState;

    public void OnClick() {
        MainGameManager.GetInstance().SwitchState(nextState);

    }
}
