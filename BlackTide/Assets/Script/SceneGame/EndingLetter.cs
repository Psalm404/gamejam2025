using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingLetter : MonoBehaviour
{
    
    [SerializeField]
    private GameObject black;

    [SerializeField]
    private GameObject letter;

    public void OnFogClick()
    {
         //���Ŷ���
        black.SetActive(false);
    }

    public void OnLetterClick()
    {
        //���Ŷ���
        MainGameManager.GetInstance().SwitchState(GameState.MiniGame);
    }

    private int flag = 0;
    public void OnClick() {
        if (flag == 0) {
           // GetComponent<Image>().sprite = Resources.Load<Sprite>("");//��
            flag = 1;
        } else if (flag == 1)
        {
            flag = 2;
            // GetComponent<Image>().sprite = Resources.Load<Sprite>("");//����
        }
        else if (flag == 2)
        {
            MainGameManager.GetInstance().SwitchState(GameState.MiniGame);
        }

    }
}
