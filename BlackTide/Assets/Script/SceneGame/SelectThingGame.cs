using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectThingGame : SceneGameBase
{
    public int TargetId;

    [SerializeField]
    private GameObject ChoicePanel;
    [SerializeField]
    private GameObject PaperButton;
    [SerializeField]
    private GameObject target;


    public bool isSuccess(int id) {
        if (id == TargetId)
        {
            ChoicePanel.SetActive(false);
            target.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            return true;            
        }
        else {
            return false;
        }
    }

    public void ShowChoosePanel() {
        ChoicePanel.SetActive(true);
        PaperButton.GetComponent<Button>().interactable = false;
    }
}
