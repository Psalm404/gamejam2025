using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggablePhoto : MonoBehaviour, IPointerDownHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Vector2 originalPosition;
    private Vector2 offset;
    public RectTransform targetArea; // 目标区域

    public Vector2 snapThreshold = new Vector2(100f,100F); // 判断到达目标区域的阈值

    public Camera cam;

    public DragPhotoSceneGame dragPhotoSceneGame;

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
            rectTransform.anchoredPosition = localPoint;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (targetArea != null)
        {
            Vector2 distanceToTarget;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(targetArea, rectTransform.position, eventData.pressEventCamera, out distanceToTarget);

            if (Mathf.Abs(distanceToTarget.x) < snapThreshold.x && Mathf.Abs(distanceToTarget.y) < snapThreshold.y)
            {
                dragPhotoSceneGame.NextPhoto();
            }
            else
            {
                rectTransform.anchoredPosition = originalPosition;
            }
        }
    }
}
