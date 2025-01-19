using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCloseButtonScene : SceneGameBase
{
    int flag = 0;
    [SerializeField]
    private GameObject button;

    [SerializeField]
    private GameObject vortex;

    [SerializeField]
    private Animator rightBlackTide;

    public override void StartPlay()
    {
        if (flag == 0)
        {
            rightBlackTide.gameObject.SetActive(false);
            MainGameManager.GetInstance().StartDialogSequence(9);
            flag = 1;
        }
    }

    public void OnButtonClick() {
        PlayAnimation();
        button.SetActive(false);
        vortex.SetActive(false);
    }

    public void PlayAnimation() {
        rightBlackTide.gameObject.SetActive(true);
        rightBlackTide.SetTrigger("Broken");
        AudioManager.GetInstance().waterWoosh.Play();
        StartCoroutine(PlayAudioAfterDelay(1f));
    }

    IEnumerator PlayAudioAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        AudioManager.GetInstance().glassCrash.Play();
    }
}
