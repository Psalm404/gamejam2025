using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bubble : MonoBehaviour
{
    [SerializeField]
    private BubbleClickGame bubbleClickGameManager;

    [SerializeField]
    private GameObject text;

    public void OnClick() {
        AudioManager.GetInstance().bubbleCrash2.Play();
        bubbleClickGameManager.ClickBubble(GetComponent<Image>());
        text.SetActive(false);
    }
}
