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
        if (flag == 0)
        {
            flag = 1;
            DialogManager.GetInstance().isInSplitDialog = true;
            MainGameManager.GetInstance().StartDialogSequence(40);
            
        }
        else if(flag == 2)
        {
            DialogManager.GetInstance().isInSplitDialog = false;
            MainGameManager.GetInstance().StartDialogSequence(44);
            flag = 3;
        }
        else if (flag == 3)
        {
            DialogManager.GetInstance().isInSplitDialog = true;
            MainGameManager.GetInstance().StartDialogSequence(45);
            flag = 4;
        }
        else if (flag == 4)
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
        Left[i].GetComponent<RectTransform>().localScale = new Vector3(1.1f, 1.1f, 1);
    }

    public void OnRightButtonClick(int i)
    {
        if (i == currentSelected)
        {
            StartCoroutine(Fadeout(Left[i].gameObject, i));
            StartCoroutine(Fadeout(Right[i].gameObject));
            currentSelected = -1;
            disappearCount++;
            if (disappearCount == 3) {
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

   
    float frameInterval = 0.1f;
    private IEnumerator Fadeout(GameObject o,int id)
    {
        int i = 0;
        while (i < 6)
        {
            i++;
            o.GetComponent<Image>().sprite = Resources.Load<Sprite>("ThroughTimeAni/" + i);
            yield return new WaitForSeconds(frameInterval);
        }
        o.SetActive(false);
        MainGameManager.GetInstance().StartDialogSequence(41 + id);
    }

    private IEnumerator Fadeout(GameObject o)
    {
        int i = 0;
        while (i < 6)
        {
            i++;
            o.GetComponent<Image>().sprite = Resources.Load<Sprite>("ThroughTimeAni/" + i);
            yield return new WaitForSeconds(frameInterval);
        }
        o.SetActive(false);
    }
}
