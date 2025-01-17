using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragBubbleSceneGame : MonoBehaviour
{
    [SerializeField]
    private GameObject LeftBubble;

    [SerializeField]
    private GameObject RightBubble;

    [SerializeField]
    private GameObject Target;


    public void OnFinish() {
        //¶¯»­
        LeftBubble.SetActive(false);
        RightBubble.SetActive(false);
        Target.SetActive(false);
        MainGameManager.GetInstance().SwitchState(GameState.SceneGame);
    }
}
