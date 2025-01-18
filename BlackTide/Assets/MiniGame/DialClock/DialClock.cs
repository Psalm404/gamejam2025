using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialClock : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    public float speed = -30f;  // ��ת�ٶȣ�ÿ����ٶȣ�
    private RectTransform rectTransform;  // UI Ԫ�ص� RectTransform
    private bool isDragging = false;  // �Ƿ������϶�

    private Vector3 lastMousePosition;  // ��һ������λ�ã����ڼ����϶�����

    private float totalRotation = 0f;  // ����ת�Ƕȣ��ۼ���ת�ĽǶȣ�
    private float previousAngle = 0f;  // ��һ֡�ĽǶ�

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();  // ��ȡ RectTransform ���
        rectTransform.pivot = new Vector2(0f, 0f);  // ���÷������ת����Ϊ���½�
    }

    // Update is called once per frame
    void Update()
    {
        // ���û���϶����Ͱ�˳ʱ�뷽���Զ�ת��
        if (!isDragging)
        {
            float rotationAmount = speed * Time.deltaTime;  // ����ÿ֡ʱ�������ת�Ƕ�
            rectTransform.rotation = Quaternion.Euler(0, 0, rectTransform.eulerAngles.z + rotationAmount);  // Ӧ���µ���ת�Ƕ�
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pointer Down");
        if (eventData.pointerEnter != null)
        {
            isDragging = true;
            lastMousePosition = Input.mousePosition;  // ���浱ǰ����λ��
            previousAngle = rectTransform.eulerAngles.z;  // ��¼��ǰ�ĽǶ�
            totalRotation = 0f;  // �����ܽǶ�
        }
    }

    // ������ͷ�ʱֹͣ�϶�
    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
    }

    // ���϶�����ʱ���õĺ���
    public void OnDrag(PointerEventData eventData)
    {
        if (isDragging)
        {
            Vector3 direction = Input.mousePosition - rectTransform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            // ����ǶȲ�ֵ��������ʱ����ת��
            float angleDifference = angle - previousAngle;

            // ȷ���ǶȲ�ֵ�� -180 �� 180 ֮��
            if (angleDifference < -180f)
                angleDifference += 360f;
            else if (angleDifference > 180f)
                angleDifference -= 360f;

            totalRotation += angleDifference;  // �ۼӽǶȲ�ֵ

            // �ж���ת�Ƕ��Ƿ�ﵽ��Ȧ����ʱ����ת��
            if (totalRotation >= 1080f)  // ��ʱ����ת������Ȧ
            {
                StartCoroutine(Pause());
                Debug.Log("yes");

                totalRotation = 0f;  // �����ܽǶ�
            }

            rectTransform.rotation = Quaternion.Euler(0, 0, angle - 45);
            previousAngle = angle;  // ������һ֡�ĽǶ�
        }
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(1.5f);
        MiniGameManager.GetInstance().FinishMinigame("DialClock");
    }

}
