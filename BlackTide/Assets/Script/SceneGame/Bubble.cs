using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField]
    private BubbleClickGame bubbleClickGameManager;

    public void OnClick() {
        bubbleClickGameManager.ClickBubble();
        //动画，变成黑水
        gameObject.SetActive(false);
       
    }
}
