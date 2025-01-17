using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDialogSceneGame : SceneGameBase
{
    [SerializeField]
    private GameObject[] buttons;
    private bool[] currentState = {true,true,true};
    private bool[] dialogPlayedFlag = { false, false, false, false, false, false, false };
    public void OnCharacterChange(int i) {
        currentState[i] = !currentState[i];
        buttons[i].GetComponent<Image>().color = new Color(1,1,1, currentState[i]?1:0.2f); 
    }

    public void PlayDialog() {
        int id = (currentState[0] ? 1 : 0 )+ (currentState[1] ? 2 : 0 )+ (currentState[2] ? 4 : 0);
        if (id == 0) {
            return;
        }
        dialogPlayedFlag[id - 1] = true;
        MainGameManager.GetInstance().StartDialogSequence(id + 100);
    }

    public override void StartPlay()
    {
        for (int i = 0; i < 7; i++) {
            if (!dialogPlayedFlag[i]) {
                return;
            }
        }
        MainGameManager.GetInstance().SwitchState(GameState.SceneGame);
    }
}
