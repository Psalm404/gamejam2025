
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private GridCell[] gridCells;
    private bool isPuzzleComplete = false;

    void Start()
    {
        // ��ȡ���������з���
        gridCells = FindObjectsOfType<GridCell>();

        // ���ķ���״̬�仯�¼�
        GridCell.OnRotationStateChanged += CheckPuzzleCompletion;
    }

    void OnDestroy()
    {
        GridCell.OnRotationStateChanged -= CheckPuzzleCompletion;
    }

    // ������з����Ƿ�����ȷλ��
    private void CheckPuzzleCompletion()
    {
        foreach (var cell in gridCells)
        {
            if (cell.isCorrect == false)
            {
                return;
            }
        }

        isPuzzleComplete = true;
        Debug.Log("Puzzle Complete!");
        OnPuzzleComplete();
    }

    // �ɹ�ʱ���߼�
    private void OnPuzzleComplete()
    {
        StartCoroutine(Pause());
       
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(1.5f);
        MiniGameManager.GetInstance().FinishMinigame("RotateJigsaw");
    }
}