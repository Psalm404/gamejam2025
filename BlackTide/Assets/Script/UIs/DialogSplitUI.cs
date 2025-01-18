using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogSplitUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text characterNameLeft;
    [SerializeField]
    private TMP_Text dialogLeft;
    [SerializeField]
    private TMP_Text characterNameRight;
    [SerializeField]
    private TMP_Text dialogRight;
    [SerializeField]
    private Image background;

    public void SetDialog(string characterNameLeft, string dialogTextLeft, 
        string characterNameRight, string dialogTextRight, int backgroundSpriteID)
    {
        this.characterNameLeft.text = characterNameLeft;
        this.characterNameRight.text = characterNameRight;
        dialogLeft.text = dialogTextLeft;
        dialogRight.text = dialogTextRight;
        if (backgroundSpriteID == 0)
        {
            background.color = new Color(1, 1, 1, 0);
        }
        else
        {
            background.color = new Color(1, 1, 1, 1);
            background.sprite = Resources.Load<Sprite>("Background/" + backgroundSpriteID);
        }
    }

    public void OnClick()
    {
        DialogManager.GetInstance().NextDialog();
    }

}
