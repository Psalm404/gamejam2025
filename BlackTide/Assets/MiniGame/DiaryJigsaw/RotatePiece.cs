using UnityEngine;

public class FloatEffect : MonoBehaviour
{
    public float floatHeight = 30f; // 漂浮的高度
    public float floatSpeed = 2f;  // 漂浮的速度

    private Vector3 initialPosition; // 记录图片的初始位置
    private bool isDragging = false; // 是否正在拖拽

    void Start()
    {
        // 初始化初始位置
        initialPosition = transform.localPosition;
    }

    void Update()
    {
        if (isDragging)
            return; // 如果正在拖拽，跳过漂浮更新

        // 漂浮效果（上下波动）
        float newY = initialPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.localPosition = new Vector3(initialPosition.x, newY, initialPosition.z);
    }

    // 设置拖拽状态
    public void SetDraggingState(bool dragging)
    {
        isDragging = dragging;
    }
}
