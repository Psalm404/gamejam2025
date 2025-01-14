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
    GameObject FullScreen;
    [SerializeField]
    GameObject LeftSide;
    [SerializeField]
    GameObject RightSide;



    private void Start()
    {
        FullScreen.SetActive(true);
        LeftSide.SetActive(false);
        RightSide.SetActive(false);
    }

    public void OnBottleCoverClick() {
        bottleCoverAni.SetTrigger("Click");
        //AudioManager.GetInstance().xxx.play();
        LeftSide.SetActive(true);
        RightSide.SetActive(true);
        OnScreenSeparate();
    }

    public void OnScreenSeparate()
    {
        StartCoroutine(SlidePanelIn());
    }

    public void OnPhoneClick()
    {
        phoneAni.gameObject.SetActive(false);
        LeftSide.GetComponent<Image>().sprite = Resources.Load<Sprite>("TempForTest/d1");
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
            LeftSide.GetComponent<Image>().color = new Color(1, 1, 1, Mathf.Lerp(0, 1, t));
            RightSide.GetComponent<Image>().color = new Color(1, 1, 1, Mathf.Lerp(0, 1, t));
            phoneAni.gameObject.GetComponent<Image>().color = new Color(1, 1, 1, Mathf.Lerp(0, 1, t));
            yield return null;
        }

        LeftSide.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        RightSide.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        phoneAni.gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        PhoneCall();
    }
}
