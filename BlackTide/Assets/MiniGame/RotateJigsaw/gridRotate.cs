using UnityEngine;
using UnityEngine.EventSystems;

public class GridCell : MonoBehaviour
{

    public float initialRotate;
    public float rotationAngle = 90f; // ÿ����ת�ĽǶ�
    public float rotationSpeed = 10f; // ��ת�ٶ�
    public float totalRotate;
    private Quaternion targetRotation;
    private bool isRotating = false;

    public int rotateCount = 0;

    public bool isCorrect = false; // ��ǰ�Ƿ�ﵽĿ��Ƕ�

    public delegate void RotationStateChange();
    public static event RotationStateChange OnRotationStateChanged;


    private void Start()
    {
        
        // ������� 90��180 �� 270 ����ת�Ƕ�
        int[] angles = { 90, 180, 270 };
        int randomIndex = Random.Range(0, angles.Length); // ���� 0, 1, 2 ���������
        initialRotate = angles[randomIndex];

        // Ӧ�������ת
        transform.rotation = Quaternion.Euler(0, 0, initialRotate);
        targetRotation = transform.rotation;


    }
    public void checkFinish() {
        rotateCount++;
        totalRotate = rotateCount % (360 / rotationAngle) * rotationAngle;
        if (totalRotate + initialRotate == 360)
        {
            isCorrect = true;
            OnRotationStateChanged?.Invoke(); // ֪ͨ״̬����
        }
        else {
            isCorrect = false;
        }
    }
    // ���ʱ������ת
    public void OnClick(BaseEventData eventData)
    {
        if (isRotating) return;

        // ����Ŀ����ת�Ƕ�
        targetRotation *= Quaternion.Euler(0, 0,rotationAngle);
        StartCoroutine(RotateToTarget());
      
    }

    private System.Collections.IEnumerator RotateToTarget()
    {
        isRotating = true;
        while (Quaternion.Angle(transform.rotation, targetRotation) > 0.1f)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
            yield return null;
        }
        transform.rotation = targetRotation;
        isRotating = false;

        checkFinish();
    }
}