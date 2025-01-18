using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintLine : MonoBehaviour
{
    private Vector3 dragStartPosition;
    private Vector3 dragEndPosition;
    public GameObject[] paintings;  // ���治ͬλ�õ�Array
    public GameObject[] prefabs;    // ���治ͬ��prefab
    private bool isDragging = false;
    public float xDistance;
    public float yDistance;
    private bool isValidLine = false;
    public int inputDirection; // 1�ϣ�2�£�3��4��

    private List<int> generatedDirections = new List<int>();  // �洢���ɵķ���˳��

    public CanvasGroup bookGroup;
    public CanvasGroup arrowGroup;
    void Start()
    {
    }

    void Update()
    {
        // �����갴��
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            dragStartPosition = Input.mousePosition;
            isValidLine = false;
            inputDirection = 0;
        }

        // �������϶�
        if (isDragging)
        {
            dragEndPosition = Input.mousePosition;
        }

        // �������ɿ�
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
                // �ж�����ķ���
                if (Mathf.Abs(xDistance) > Mathf.Abs(yDistance) && xDistance > 0)
                {
                    inputDirection = 3; // ��
                }
                else if (Mathf.Abs(xDistance) > Mathf.Abs(yDistance) && xDistance < 0)
                {
                    inputDirection = 4; // ��
                }
                else if (Mathf.Abs(xDistance) < Mathf.Abs(yDistance) && yDistance > 0)
                {
                    inputDirection = 1; // ��
                }
                else if (Mathf.Abs(xDistance) < Mathf.Abs(yDistance) && yDistance < 0)
                {
                    inputDirection = 2; // ��
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
        if (inputDirection == 1)  // ��
        {
            InstantiatePrefabAtPosition(paintings[0]);
        }
        else if (inputDirection == 2)  // ��
        {
            InstantiatePrefabAtPosition(paintings[1]);
        }
        else if (inputDirection == 3)  // ��
        {
            InstantiatePrefabAtPosition(paintings[2]);
        }

        // �������µ� prefab �󣬼�����ɵ�˳��
      
        CheckSuccessSequence();
    }

    private void InstantiatePrefabAtPosition(GameObject position)
    {
        int index = Mathf.Abs(inputDirection) - 1;

        if (index >= 0 && index < prefabs.Length)
        {
            // �� position λ��ʵ���� prefab������ʵ������Ϊ position ���Ӷ���
            GameObject newPrefab = Instantiate(prefabs[index], position.transform.position, Quaternion.identity);

            // ������ʵ���ĸ�����Ϊ paintings[0] ���ڵĸ�����
            newPrefab.transform.SetParent(position.transform.parent);

            // ����ʵ����ԭʼ��С
            newPrefab.transform.localScale = prefabs[index].transform.localScale;

            Debug.Log("Instantiated prefab at position: " + position.transform.position);
            inputDirection = 0;
        }
        else
        {
            Debug.LogWarning("Prefab index out of range.");
        }
    }

    // ������ɵ�˳���Ƿ���3 1 2
    private void CheckSuccessSequence()
    {
        // ������ɵ�˳��ﵽ 3, 1, 2����� success
        if (generatedDirections.Count >= 3)

        {
            
            // �������������ɵķ���
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
