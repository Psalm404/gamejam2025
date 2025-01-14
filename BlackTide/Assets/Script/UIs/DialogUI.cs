using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text name;
    [SerializeField]
    private TMP_Text dialog;

    public void SetDialog(string characterName, string dialogText)
    {
        name.text = characterName;
        dialog.text = dialogText;
    }

    public void OnClick() {
        DialogManager.GetInstance().NextDialog();
    }
}
