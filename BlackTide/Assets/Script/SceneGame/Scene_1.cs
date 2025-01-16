using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene_1 : SceneGameBase
{
    [SerializeField]
    Animator bottleCoverAni;
    [SerializeField]
    Animator phoneAni;

    [SerializeField]
    GameObject View1;
    [SerializeField]
    GameObject View2;

    public override void StartPlay() {
        UIManager.GetInstance().CurtainAnimation("FadeOut");
        View1.SetActive(true);
        View2.SetActive(false);
    }

    public void OnBottleCoverClick() {
        bottleCoverAni.SetTrigger("Click");
        //AudioManager.GetInstance().xxx.play();
        View2.SetActive(true);
        OnScreenSeparate();
    }

    public void OnScreenSeparate()
    {
        StartCoroutine(SlidePanelIn());
    }

    public void OnPhoneClick()
    {
        phoneAni.gameObject.SetActive(false);
        MainGameManager.GetInstance().StartDialogSequence(0);
    }

    public void PhoneCall()
    {
        phoneAni.SetTrigger("Call");
    }


    private IEnumerator SlidePanelIn()
    {
        float waitTime = 1f;
        float duration = 2.0f; 
        float elapsed = 0.0f;

        while (elapsed < waitTime)
        {
            elapsed += Time.deltaTime;
            yield return null;
        }

        elapsed = 0.0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / duration;
            View2.GetComponent<Image>().color = new Color(1, 1, 1, Mathf.Lerp(0, 1, t));
            phoneAni.gameObject.GetComponent<Image>().color = new Color(1, 1, 1, Mathf.Lerp(0, 1, t));
            yield return null;
        }

        View2.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        phoneAni.gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        PhoneCall();
    }
}
