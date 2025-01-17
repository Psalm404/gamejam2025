using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text characterName;
    [SerializeField]
    private TMP_Text dialog;
    [SerializeField]
    private Image background;

    public void SetDialog(string characterName, string dialogText, int backgroundSpriteID)
    {
        this.characterName.text = characterName;
        dialog.text = dialogText;
        background.sprite = Resources.Load<Sprite>("Background/" + backgroundSpriteID);
    }

    public void OnClick() {
        DialogManager.GetInstance().NextDialog();
    }
}
