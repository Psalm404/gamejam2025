using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragBubbleSceneGame : SceneGameBase
{
    [SerializeField]
    private GameObject LeftBubble;

    [SerializeField]
    private GameObject RightBubble;

    [SerializeField]
    private GameObject Target;

    [SerializeField]
    private GameObject Finish;

    public override void StartPlay()
    {
        StartCoroutine(FadeIn(LeftBubble));
        StartCoroutine(FadeIn(RightBubble));
        StartCoroutine(FadeIn(gameObject));
    }


    public void OnFinish() {
        //¶¯»­
        StartCoroutine(Fadeout(LeftBubble));
        StartCoroutine(Fadeout(RightBubble));
        StartCoroutine(FinishGame(Finish));
        Target.SetActive(false);
       
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

    private IEnumerator FadeIn(GameObject o)
    {
        o.SetActive(true);
        float elapsedTime = 0.0f;
        float duration = 2.0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;
            o.GetComponent<Image>().color = new Color(1, 1, 1, Mathf.Lerp(0, 1, t));
            yield return null;
        }
    }

    private IEnumerator FinishGame(GameObject o)
    {
        o.SetActive(true);
        float elapsedTime = 0.0f;
        float duration = 2.0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;
            o.GetComponent<Image>().color = new Color(1, 1, 1, Mathf.Lerp(0, 1, t));
            yield return null;
        }

        elapsedTime = 0.0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        MainGameManager.GetInstance().SwitchState(GameState.SceneGame);
    }

}
