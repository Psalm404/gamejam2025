using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialClock : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    public float speed = -30f;  // 旋转速度（每秒多少度）
    private RectTransform rectTransform;  // UI 元素的 RectTransform
    private bool isDragging = false;  // 是否正在拖动

    private Vector3 lastMousePosition;  // 上一次鼠标的位置，用于计算拖动方向

    private float totalRotation = 0f;  // 总旋转角度（累计旋转的角度）
    private float previousAngle = 0f;  // 上一帧的角度

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();  // 获取 RectTransform 组件
        rectTransform.pivot = new Vector2(0f, 0f);  // 设置分针的旋转中心为左下角
    }

    // Update is called once per frame
    void Update()
    {
        // 如果没有拖动，就按顺时针方向自动转动
        if (!isDragging)
        {
            float rotationAmount = speed * Time.deltaTime;  // 根据每帧时间计算旋转角度
            rectTransform.rotation = Quaternion.Euler(0, 0, rectTransform.eulerAngles.z + rotationAmount);  // 应用新的旋转角度
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pointer Down");
        if (eventData.pointerEnter != null)
        {
            isDragging = true;
            lastMousePosition = Input.mousePosition;  // 保存当前鼠标的位置
            previousAngle = rectTransform.eulerAngles.z;  // 记录当前的角度
            totalRotation = 0f;  // 重置总角度
        }
    }

    // 当鼠标释放时停止拖动
    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
    }

    // 当拖动分针时调用的函数
    public void OnDrag(PointerEventData eventData)
    {
        if (isDragging)
        {
            Vector3 direction = Input.mousePosition - rectTransform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            // 计算角度差值（考虑逆时针旋转）
            float angleDifference = angle - previousAngle;

            // 确保角度差值在 -180 到 180 之间
            if (angleDifference < -180f)
                angleDifference += 360f;
            else if (angleDifference > 180f)
                angleDifference -= 360f;

            totalRotation += angleDifference;  // 累加角度差值

            // 判断旋转角度是否达到三圈（逆时针旋转）
            if (totalRotation >= 1080f)  // 逆时针旋转超过三圈
            {
                StartCoroutine(Pause());
                Debug.Log("yes");

                totalRotation = 0f;  // 重置总角度
            }

            rectTransform.rotation = Quaternion.Euler(0, 0, angle - 45);
            previousAngle = angle;  // 更新上一帧的角度
        }
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(1.5f);
        MiniGameManager.GetInstance().FinishMinigame("DialClock");
    }

}
