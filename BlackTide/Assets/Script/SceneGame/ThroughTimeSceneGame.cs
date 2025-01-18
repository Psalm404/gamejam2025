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
            StartCoroutine(Fadeout(Left[i].gameObject));
            StartCoroutine(Fadeout(Right[i].gameObject));
            currentSelected = -1;
            disappearCount++;
            if (disappearCount == 3) {
                flag = 2;
            }
            MainGameManager.GetInstance().StartDialogSequence(41 + i);
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

    private IEnumerator Fadeout(GameObject o)
    {
      
        float elapsedTime = 0.0f;
        float duration = 2.0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;
            o.GetComponent<Image>().color = new Color(1, 1, 1, Mathf.Lerp(1, 0, t));
            yield return null;
        }
        o.SetActive(false);
    }
}
