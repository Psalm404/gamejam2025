using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickHandSceneGame : SceneGameBase
{
    [SerializeField]
    private GameObject Back0_HandIn;
    [SerializeField]
    private GameObject Back0_StopDown;
    [SerializeField]
    private GameObject Back0_Relax;

    [SerializeField]
    private GameObject Back1_HandRelax;
    [SerializeField]
    private GameObject Back2_PaperIn;
    [SerializeField]
    private GameObject Paper;
    [SerializeField]
    private GameObject Back3_TearClearAndPaperBack;

    [SerializeField]
    private GameObject Back4_Warm;

    [SerializeField]
    private Button button;


    [SerializeField]
    private int i = 0;
    public void OnClick() {
       if (i == 1)
        {
            StartCoroutine(FadeOutAndIn(Back0_Relax, Back1_HandRelax));
            i = 2;
        }
        else if (i == 2)
        {
            StartCoroutine(FadeOutAndIn(Back1_HandRelax, Back2_PaperIn));
            i = 3;
        }
    }

    public void OnPaperClick()
    {
        StartCoroutine(FadeOutAndIn(Back2_PaperIn, Back3_TearClearAndPaperBack));
        i = 4;
    }

    public override void StartPlay()
    {
        if (i == 0)
        {
            StartCoroutine(FadeOutAndIn(Back0_HandIn, Back0_StopDown, Back0_Relax));
            i = 1;
        }
        else if (i == 4)
        {
            i = 5;
            StartCoroutine(FadeOutAndIn(Back3_TearClearAndPaperBack, Back4_Warm));
        }
    }

    private IEnumerator FadeOutAndIn(GameObject o1, GameObject o2, GameObject o3)
    {
        float elapsedTime = 0.0f;
        float duration = 2.0f;

        button.interactable = false;

        o2.SetActive(true);
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;
            o1.GetComponent<Image>().color = new Color(1, 1, 1, Mathf.Lerp(1, 0, t));
            o2.GetComponent<Image>().color = new Color(1, 1, 1, Mathf.Lerp(0, 1, t));
            yield return null;
        }
        o1.SetActive(false);
        o2.GetComponent<Image>().color = new Color(1, 1, 1, 1);

        elapsedTime = 0.0f;
        o3.SetActive(true);
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;
            o2.GetComponent<Image>().color = new Color(1, 1, 1, Mathf.Lerp(1, 0, t));
            o3.GetComponent<Image>().color = new Color(1, 1, 1, Mathf.Lerp(0, 1, t));
            yield return null;
        }
        o2.SetActive(false);
        o3.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        button.interactable = true;
        if (i == 3)
        {
            MainGameManager.GetInstance().SwitchState(GameState.Dialog);//擦擦眼泪吧

        }
        else if (i == 4)
        {
            MainGameManager.GetInstance().SwitchState(GameState.Dialog);//保管好好不好，不要乱丢哦
        }
    }


    private IEnumerator FadeOutAndIn(GameObject ToInactive, GameObject ToActive)
    {
        float elapsedTime = 0.0f;
        float duration = 2.0f;
        ToActive.SetActive(true);
        button.interactable = false;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;
            ToInactive.GetComponent<Image>().color= new Color(1,1,1,Mathf.Lerp(1, 0, t));
            ToActive.GetComponent<Image>().color = new Color(1, 1, 1, Mathf.Lerp(0, 1, t));
            if (i == 3) {
                Paper.GetComponent<Image>().color = new Color(1, 1, 1, Mathf.Lerp(0, 1, t));
            }
            yield return null;
        }
        button.interactable = true;
        ToInactive.SetActive(false);
        ToActive.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        if (i == 3) {
            MainGameManager.GetInstance().SwitchState(GameState.Dialog);

        } else if (i == 4) {
            MainGameManager.GetInstance().SwitchState(GameState.Dialog);
        }
        else if (i == 5)
        {
            MainGameManager.GetInstance().SwitchState(GameState.Dialog);
        }
    }

    private IEnumerator FadeOutAndIn(GameObject ToInactive)
    {
        float elapsedTime = 0.0f;
        float duration = 2.0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;
            ToInactive.GetComponent<Image>().color = new Color(1, 1, 1, Mathf.Lerp(1, 0, t));
            yield return null;
        }
        ToInactive.SetActive(false);
    }
}
