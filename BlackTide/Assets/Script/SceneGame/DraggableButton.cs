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
    public float snapThreshold = 400f; // 判断到达目标区域的阈值

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
            Vector2 distanceToTarget = RectTransformUtility.WorldToScreenPoint(cam, rectTransform.position)
                - RectTransformUtility.WorldToScreenPoint(cam, targetArea.position);
            Debug.Log(RectTransformUtility.WorldToScreenPoint(cam, rectTransform.position));
            Debug.Log(RectTransformUtility.WorldToScreenPoint(cam, targetArea.position));
            // Vector2 distanceToTarget = rectTransform.anchoredPosition - targetArea.anchoredPosition;
            if (Mathf.Abs(distanceToTarget.x) < snapThreshold && Mathf.Abs(distanceToTarget.y) < snapThreshold)
            {
                // 到达目标位置，触发事件
                Debug.Log("Button snapped to target position.");
                // 你可以在这里调用其他事件或方法
            }
            else
            {
                // 未到达目标位置，返回原始位置
                rectTransform.anchoredPosition = originalPosition;
            }
        }
    }
  
}
