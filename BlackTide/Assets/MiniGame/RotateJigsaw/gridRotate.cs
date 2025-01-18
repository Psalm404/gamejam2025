using UnityEngine;
using UnityEngine.EventSystems;

public class GridCell : MonoBehaviour
{

    public float initialRotate;
    public float rotationAngle = 90f; // 每次旋转的角度
    public float rotationSpeed = 10f; // 旋转速度
    public float totalRotate;
    private Quaternion targetRotation;
    private bool isRotating = false;

    public int rotateCount = 0;

    public bool isCorrect = false; // 当前是否达到目标角度

    public delegate void RotationStateChange();
    public static event RotationStateChange OnRotationStateChanged;


    private void Start()
    {
        
        // 随机生成 90、180 或 270 的旋转角度
        int[] angles = { 90, 180, 270 };
        int randomIndex = Random.Range(0, angles.Length); // 生成 0, 1, 2 的随机索引
        initialRotate = angles[randomIndex];

        // 应用随机旋转
        transform.rotation = Quaternion.Euler(0, 0, initialRotate);
        targetRotation = transform.rotation;


    }
    public void checkFinish() {
        rotateCount++;
        totalRotate = rotateCount % (360 / rotationAngle) * rotationAngle;
        if (totalRotate + initialRotate == 360)
        {
            isCorrect = true;
            OnRotationStateChanged?.Invoke(); // 通知状态更新
        }
        else {
            isCorrect = false;
        }
    }
    // 点击时触发旋转
    public void OnClick(BaseEventData eventData)
    {
        if (isRotating) return;

        // 设置目标旋转角度
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