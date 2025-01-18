
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
        // 获取场景中所有方块
        gridCells = FindObjectsOfType<GridCell>();

        // 订阅方块状态变化事件
        GridCell.OnRotationStateChanged += CheckPuzzleCompletion;
    }

    void OnDestroy()
    {
        GridCell.OnRotationStateChanged -= CheckPuzzleCompletion;
    }

    // 检查所有方块是否都在正确位置
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

    // 成功时的逻辑
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