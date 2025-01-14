using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePanel : MonoBehaviour
{
    public event Action gameEnded;

    public void EndGame()
    {
        gameEnded?.Invoke(); 
    }
}
