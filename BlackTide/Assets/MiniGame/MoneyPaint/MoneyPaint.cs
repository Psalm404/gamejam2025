using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoneyPaint : MonoBehaviour, IPointerDownHandler
{
    public CanvasGroup[] paintGroup;
    public GameObject[] paintList;
    public Color curColor;
    public int colorCount;


    private void Start()
    {
        foreach (var group in paintGroup)
        {
            group.alpha = 0;
        }
    }

    private void Update()
    {
        CheckFinish();
    }
    private void CheckFinish()
    {
      foreach(var group in paintGroup)
        {
            if (group.alpha != 1) {
                return;
            }
        }
        StartCoroutine(Pause());
    }
    public void paint(int colorCode)
    {
        colorCount = colorCode;

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("pointDown");
        if (eventData.pointerEnter != null)
        {
            Debug.Log(eventData.pointerEnter.transform.name);
            for (int i = 0; i < paintList.Count(); i++)
            {
                Debug.Log(eventData.pointerEnter.transform.name + " " + paintList[i].name);
                if (eventData.pointerEnter.transform.name == paintList[i].name)
                {
                    if (i == colorCount)
                    {
                        paintGroup[i].alpha = 1;
                    }
                }
            }
        }
    }
    IEnumerator Pause()
    {
        yield return new WaitForSeconds(1.5f);
        MiniGameManager.GetInstance().FinishMinigame("MoneyPaint");
    }
}
