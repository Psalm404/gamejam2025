using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintLine : MonoBehaviour
{
    private Vector3 dragStartPosition;
    private Vector3 dragEndPosition;
    public GameObject[] paintings;  // 保存不同位置的Array
    public GameObject[] prefabs;    // 保存不同的prefab
    private bool isDragging = false;
    public float xDistance;
    public float yDistance;
    private bool isValidLine = false;
    public int inputDirection; // 1上，2下，3左，4右

    private List<int> generatedDirections = new List<int>();  // 存储生成的方向顺序

    public CanvasGroup bookGroup;
    public CanvasGroup arrowGroup;
    void Start()
    {
    }

    void Update()
    {
        // 检测鼠标按下
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            dragStartPosition = Input.mousePosition;
            isValidLine = false;
            inputDirection = 0;
        }

        // 检测鼠标拖动
        if (isDragging)
        {
            dragEndPosition = Input.mousePosition;
        }

        // 检测鼠标松开
        if (Input.GetMouseButtonUp(0) && isDragging)
        {
            isDragging = false;
            xDistance = dragEndPosition.x - dragStartPosition.x;
            yDistance = dragEndPosition.y - dragStartPosition.y;

            Debug.Log("Drag length: " + xDistance + " " + yDistance);
            if (Mathf.Abs(xDistance) > 100 || Mathf.Abs(yDistance) > 100)
            {
                isValidLine = true;
            }

            if (isValidLine)
            {
                // 判断输入的方向
                if (Mathf.Abs(xDistance) > Mathf.Abs(yDistance) && xDistance > 0)
                {
                    inputDirection = 3; // 右
                }
                else if (Mathf.Abs(xDistance) > Mathf.Abs(yDistance) && xDistance < 0)
                {
                    inputDirection = 4; // 左
                }
                else if (Mathf.Abs(xDistance) < Mathf.Abs(yDistance) && yDistance > 0)
                {
                    inputDirection = 1; // 上
                }
                else if (Mathf.Abs(xDistance) < Mathf.Abs(yDistance) && yDistance < 0)
                {
                    inputDirection = 2; // 下
                }

                CheckInput();
                isValidLine = false;
            }
        }
    }

    private void CheckInput()
    {
        if (inputDirection == 0 || inputDirection == 4)
        {
            return;
        }
        generatedDirections.Add(inputDirection);
        if (inputDirection == 1)  // 上
        {
            InstantiatePrefabAtPosition(paintings[0]);
        }
        else if (inputDirection == 2)  // 下
        {
            InstantiatePrefabAtPosition(paintings[1]);
        }
        else if (inputDirection == 3)  // 右
        {
            InstantiatePrefabAtPosition(paintings[2]);
        }

        // 在生成新的 prefab 后，检查生成的顺序
      
        CheckSuccessSequence();
    }

    private void InstantiatePrefabAtPosition(GameObject position)
    {
        int index = Mathf.Abs(inputDirection) - 1;

        if (index >= 0 && index < prefabs.Length)
        {
            // 在 position 位置实例化 prefab，并将实例设置为 position 的子对象
            GameObject newPrefab = Instantiate(prefabs[index], position.transform.position, Quaternion.identity);

            // 设置新实例的父对象为 paintings[0] 所在的父对象
            newPrefab.transform.SetParent(position.transform.parent);

            // 保持实例的原始大小
            newPrefab.transform.localScale = prefabs[index].transform.localScale;

            Debug.Log("Instantiated prefab at position: " + position.transform.position);
            inputDirection = 0;
        }
        else
        {
            Debug.LogWarning("Prefab index out of range.");
        }
    }

    // 检查生成的顺序是否是3 1 2
    private void CheckSuccessSequence()
    {
        // 如果生成的顺序达到 3, 1, 2，输出 success
        if (generatedDirections.Count >= 3)

        {
            
            // 检查最后三个生成的方向
            int count = generatedDirections.Count;
            Debug.Log("direction = " + generatedDirections[count - 3] + generatedDirections[count - 2] + generatedDirections[count - 1]);
            if (generatedDirections[count - 3] == 1 && generatedDirections[count - 2] == 2 && generatedDirections[count - 1] == 3)
            {
                
                Debug.Log("Success! The sequence is 1 2 3.");
                StartCoroutine(FadeInAndOut());
            }
        }
    }

    IEnumerator FadeInAndOut()
    {
        Debug.Log("fade");
        float fadeDuration = 1.8f;
        float timeElapsed = 0f;

        while (timeElapsed < fadeDuration)
        {
            bookGroup.alpha = Mathf.Lerp(0f, 1f, timeElapsed / fadeDuration);
            arrowGroup.alpha = Mathf.Lerp(1f, 0f, timeElapsed / fadeDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        bookGroup.alpha = 1f;
        arrowGroup.alpha = 0f;
        StartCoroutine(Pause());

    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(1.5f);
        MiniGameManager.GetInstance().FinishMinigame("PaintBook");
    }
}
