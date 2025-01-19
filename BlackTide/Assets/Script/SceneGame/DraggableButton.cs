using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableButton : MonoBehaviour, IPointerDownHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Vector2 originalPosition;
    private Vector2 offset;
    public RectTransform targetArea; // 目标区域

    public float snapThreshold = 100f; // 判断到达目标区域的阈值

    public int id; // 物品id
    [SerializeField]
    private SelectThingGame selectThingGame;

    public Camera cam;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        originalPosition = rectTransform.anchoredPosition;
        cam = GameObject.Find("MainCamera").GetComponent<Camera>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, eventData.position, eventData.pressEventCamera, out offset);
        offset = rectTransform.anchoredPosition - offset;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.parent as RectTransform, eventData.position, eventData.pressEventCamera, out Vector2 localPoint))
        {
            rectTransform.anchoredPosition = offset + localPoint;
        }
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        if (targetArea != null)
        {
            Vector2 distanceToTarget;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(targetArea, eventData.position, eventData.pressEventCamera, out distanceToTarget);
           
            if (Mathf.Abs(distanceToTarget.x) < snapThreshold && Mathf.Abs(distanceToTarget.y) < snapThreshold)
            {
                if (selectThingGame.isSuccess(id))
                {
                    MainGameManager.GetInstance().SwitchState(GameState.SceneGame);
                }
                else {
                    rectTransform.anchoredPosition = originalPosition;
                }
            }
            else
            {
                rectTransform.anchoredPosition = originalPosition;
            }
        }
    }
  
}
