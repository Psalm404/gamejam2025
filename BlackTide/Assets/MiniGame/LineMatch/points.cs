using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ui_thread : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerEnterHandler, IEndDragHandler
{
    public Canvas canvas;
    public RectTransform fingerLine;

    public List<GameObject> games = new List<GameObject>();

    [SerializeField]
    private CanvasGroup pointsCanvasGroup;

    [SerializeField]
    private CanvasGroup buildingsCanvasGroup;

    // 测试起点位置
    public RectTransform start;

    // 手指或鼠标在屏幕上的点击位置
    private Vector3 touchPos;

    private bool isPress = false;

    // MiniGamePanel 的 GameObject
    public GameObject miniGamePanel;

    private bool isFinish = false;


    // 所需的正确顺序点列表
    public List<GameObject> requiredOrder = new List<GameObject>();

    // 检测是否在 MiniGamePanel 的子组件内
    private bool IsInMiniGamePanel(GameObject target)
    {
        if (miniGamePanel == null)
        {
            Debug.LogError("MiniGamePanel is not assigned!");
            return false;
        }

        foreach (Transform child in miniGamePanel.transform)
        {
            if (child.gameObject == target)
            {
                return true;
            }
        }

        return false;
    }

    private void UpdateFingerLine(Vector3 startPos)
    {
        Vector3 uiStartPos = Vector3.zero;
        Vector3 uitouchPos = Vector3.zero;

        if (canvas.renderMode == RenderMode.ScreenSpaceOverlay)
        {
            uiStartPos = startPos;
            uitouchPos = touchPos;
        }
        else if (canvas.renderMode == RenderMode.ScreenSpaceCamera)
        {
            Camera camera = canvas.worldCamera;

            // UI世界的起点世界坐标转换为UGUI坐标
            Vector2 screenStartPos = RectTransformUtility.WorldToScreenPoint(camera, startPos);
            RectTransformUtility.ScreenPointToWorldPointInRectangle(canvas.GetComponent<RectTransform>(), screenStartPos,
                camera, out uiStartPos);

            // 鼠标坐标转换为UGUI坐标
            RectTransformUtility.ScreenPointToWorldPointInRectangle(canvas.GetComponent<RectTransform>(), touchPos,
                camera, out uitouchPos);
        }

        fingerLine.pivot = new Vector2(0, 0.5f);
        fingerLine.position = startPos;
        fingerLine.eulerAngles = new Vector3(0, 0, GetAngle(uiStartPos, uitouchPos));
        fingerLine.sizeDelta = new Vector2(GetDistance(uiStartPos, uitouchPos), fingerLine.sizeDelta.y);
    }

    private RectTransform SetLine(RectTransform lineSource, Vector3 startPos, Vector3 endPos)
    {
        RectTransform line = lineSource; // Instantiate(lineSource, lineSource.parent);
        line.pivot = new Vector2(0, 0.5f);
        line.position = startPos;
        line.eulerAngles = new Vector3(0, 0, GetAngle(startPos, endPos));
        line.sizeDelta = new Vector2(GetDistance(startPos, endPos), lineSource.sizeDelta.y);
        return line;
    }

    private float GetAngle(Vector3 startPos, Vector3 endPos)
    {
        Vector3 dir = endPos - startPos;
        float angle = Vector3.Angle(Vector3.right, dir);
        Vector3 cross = Vector3.Cross(Vector3.right, dir);
        float dirF = cross.z > 0 ? 1 : -1;
        angle = angle * dirF;
        return angle;
    }

    private float GetDistance(Vector3 startPos, Vector3 endPos)
    {
        float distance = Vector3.Distance(endPos, startPos);
        return distance * 1 / canvas.transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.pointerEnter != null && IsInMiniGamePanel(eventData.pointerEnter))
        {
            start = (RectTransform)eventData.pointerEnter.transform;
         //   correctOrder.Add(eventData.pointerEnter);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (start != null)
        {
            if (Application.isMobilePlatform)
            {
                for (int i = 0; i < Input.touchCount; ++i)
                {
                    UnityEngine.Touch touch = Input.GetTouch(i);
                    if (touch.phase == TouchPhase.Began)
                    {
                        isPress = true;
                        touchPos = touch.position;
                    }
                    else
                    {
                        isPress = false;
                    }
                }
            }
            else
            {
                if (Input.GetMouseButton(0))
                {
                    isPress = true;
                    touchPos = Input.mousePosition;
                }
                else
                {
                    isPress = false;
                }
            }
        }

        if (isPress)
        {
            fingerLine.gameObject.SetActive(true);
            UpdateFingerLine(start.position);
        }
        else
        {
            fingerLine.gameObject.SetActive(false);
        }

        if (eventData.pointerEnter != null && IsInMiniGamePanel(eventData.pointerEnter))
        {
            if (eventData.pointerEnter.name != start.name)
            {
                bool cs = true;

                for (int i = 0; i < games.Count; i++)
                {
                    if (games[i].name == eventData.pointerEnter.name + "cs")
                    {
                        Debug.Log(eventData.pointerEnter.name);
                        Debug.Log(games[i].name);
                        cs = false;
                    }
                }

                if (cs)
                {
                    GameObject game = Instantiate(fingerLine.gameObject, start.position, Quaternion.identity, fingerLine.parent);
                    game.name = start.gameObject.name + "cs";

                    SetLine((RectTransform)game.transform, start.position, eventData.pointerEnter.transform.position);


                    games.Add(game);

                    //  Debug.Log(games.Count +" "+ requiredOrder.Count);
                    int correctCount = 0;
                    if (games.Count == requiredOrder.Count-1) {
                        for (int i = 0; i < games.Count; i++) {
                
                            if (games[i].name == requiredOrder[i].name + "cs") {
                              //  Debug.Log(i + " " + games[i].name + " " +  requiredOrder[i].name);
                              
                                correctCount++;
                                Debug.Log(correctCount);
                            }
                        }
                        
                    }
                    if (correctCount == requiredOrder.Count - 1) {

                        // 游戏结束
                        isFinish = true;
                        StartCoroutine(FadeInAndOut());
                       


                    }
                    start = (RectTransform)eventData.pointerEnter.transform;

                 
                }
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
      
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (isFinish) {
            return;
        }
        while (games.Count > 0)
        {
            Destroy(games[0]);
            games.RemoveAt(0);
        }
        start = null;
        fingerLine.gameObject.SetActive(false);
    }

    IEnumerator FadeInAndOut()
    {
        Debug.Log("fade");
        float fadeDuration = 1.5f;
        float timeElapsed = 0f;

        while (timeElapsed < fadeDuration)
        {
            pointsCanvasGroup.alpha = Mathf.Lerp(1f, 0f, timeElapsed / fadeDuration);
            buildingsCanvasGroup.alpha = Mathf.Lerp(0f, 1f, timeElapsed / fadeDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        pointsCanvasGroup.alpha = 0f;
        buildingsCanvasGroup.alpha = 1f;
        StartCoroutine(Pause());
       
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(1.5f);
        MiniGameManager.GetInstance().FinishMinigame("LineMatch");
    }
}

