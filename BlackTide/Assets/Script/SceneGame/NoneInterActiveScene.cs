using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoneInterActiveScene : MonoBehaviour
{
    public GameState nextState;

    public void OnClick() {
        MainGameManager.GetInstance().SwitchState(nextState);
    }
}
