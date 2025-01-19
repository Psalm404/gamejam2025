using UnityEngine;

public class FloatEffect : MonoBehaviour
{
    public float floatHeight = 30f; // Ư���ĸ߶�
    public float floatSpeed = 2f;  // Ư�����ٶ�

    private Vector3 initialPosition; // ��¼ͼƬ�ĳ�ʼλ��
    private bool isDragging = false; // �Ƿ�������ק

    void Start()
    {
        // ��ʼ����ʼλ��
        initialPosition = transform.localPosition;
    }

    void Update()
    {
        if (isDragging)
            return; // ���������ק������Ư������

        // Ư��Ч�������²�����
        float newY = initialPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.localPosition = new Vector3(initialPosition.x, newY, initialPosition.z);
    }

    // ������ק״̬
    public void SetDraggingState(bool dragging)
    {
        isDragging = dragging;
    }
}
