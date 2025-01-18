using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingLetter : SceneGameBase
{
    
    [SerializeField]
    private GameObject black;

    [SerializeField]
    private GameObject letter;


    private int flag = 0;
    public void OnFogClick()
    {
        if (flag == 0)
        {
            StartCoroutine(FadeOut(black.GetComponent<Image>(), 2));
            flag = 1;
        }
    }

    public void OnLetterClick()
    {
        if (flag == 1)
        {
            letter.GetComponent<Image>().sprite = Resources.Load<Sprite>("High/3");
            flag = 2;
        }else if (flag == 2)
        {
            letter.SetActive(false);
            MainGameManager.GetInstance().SwitchState(GameState.SceneGame);
            //MainGameManager.GetInstance().SwitchState(GameState.MiniGame);
        }
    }

 


    public static IEnumerator FadeOut(Image sprite, float fadeOutTime)
    {
        float duration = fadeOutTime;
        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / duration;
            sprite.color = new Color(1, 1, 1, Mathf.Lerp(1, 0, t));
            yield return null;
        }
        sprite.color = new Color(1, 1, 1, 0);
        sprite.gameObject.SetActive(false);
    }
}
