using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThroughTimeSceneGame : SceneGameBase
{
    [SerializeField]
    private List<Button> Left;

    [SerializeField]
    private List<Button> Right;

    private int currentSelected = -1;
    private int disappearCount = 0;
    private int flag = 0;
    public override void StartPlay()
    {
        if (flag == 0) {
            DialogManager.GetInstance().isInSplitDialog = true;
            MainGameManager.GetInstance().StartDialogSequence(40);
            flag = 1;
        } else if (flag == 2)
        {
            DialogManager.GetInstance().isInSplitDialog = false;
            MainGameManager.GetInstance().SwitchState(GameState.SceneGame);
        }
    }

    public void OnLeftButtonClick(int i) {
        currentSelected = i;
        foreach (Button b in Left) {
            b.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        }
        Left[i].GetComponent<RectTransform>().localScale = new Vector3(1.2f, 1.2f, 1);
        
    }

    public void OnRightButtonClick(int i)
    {
        if (i == currentSelected)
        {
            //²¥·Å¶¯»­ÏûÊ§
            Left[i].gameObject.SetActive(false);
            Right[i].gameObject.SetActive(false);
            MainGameManager.GetInstance().StartDialogSequence(41 + i);
            currentSelected = -1;
            disappearCount++;
            if (disappearCount == 3) {
                MainGameManager.GetInstance().StartDialogSequence(44);
                flag = 2;
            }
        }
        else
        {
            currentSelected = -1;
            foreach (Button b in Left)
            {
                b.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            }
        }
        
    }


}
