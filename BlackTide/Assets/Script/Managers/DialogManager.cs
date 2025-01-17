using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogEndEvent
{
    public virtual void HandleEvent() { }
}

public class PictureChangeEvent: DialogEndEvent
{
    public string pictureName;
    public int pictureType;
    public int picturePosition;

    public override void HandleEvent() {
    
    }
}

public class LoadGameEvent : DialogEndEvent
{
    public string gameName;
    public int gamePosition;
    public override void HandleEvent()
    {

    }
}

public class StateChangeEvent : DialogEndEvent
{
    public string stateName;
    public int stateType;
    public int num;

    public override void HandleEvent()
    {

    }
}

public class DialogSequence //�м�û���κ�����������һ��Ի�
{
    private int dialogSequenceID;
    private List<Dialog> dialogs = new List<Dialog>();
    private int nextSequenceID;
   

    private int current = -1;

    public GameState nextState;

    public DialogSequence(int dialogSequenceID, int nextSequenceID, GameState nextState)
    {
        this.dialogSequenceID = dialogSequenceID;
        this.nextSequenceID = nextSequenceID;
        this.nextState = nextState;
    }

    public void AddDialog(Dialog d) {
        dialogs.Add(d);
    }

    public int GetSize() {
        return dialogs.Count;
    }

    public int GetNextSequenceID() {
        return nextSequenceID;
    }

    public int GetSequenceID()
    {
        return dialogSequenceID;
    }

    public Dialog GetNextDialog() {
        if (current < dialogs.Count)
        {
            current++;
            return dialogs[current];
        }
        else {
            return null;
        }
    }
}

public class Dialog {
    protected string characterName;
    protected string dialogText;
    protected int dialogBackground;

    public Dialog() { }
    public Dialog(string characterName, string dialogText, int dialogBackground) {
        this.characterName = characterName;
        this.dialogText = dialogText;
        this.dialogBackground = dialogBackground;
    }

    public Dialog(string characterName, string dialogText)
    {
        this.characterName = characterName;
        this.dialogText = dialogText;
        this.dialogBackground = 0;
    }

    public string GetCharacterName() {
        return characterName;
    }
    public string GetDialogText()
    {
        return dialogText;
    }
    public int GetDialogBackground()
    {
        return dialogBackground;
    }

}

public class DialogSplit : Dialog
{
    protected string characterNameRight;
    protected string dialogTextRight;

    public DialogSplit(string characterName, string dialogText, 
        string characterNameRight, string dialogTextRight, int dialogBackground)
    {
        this.characterName = characterName;
        this.dialogText = dialogText;
        this.characterNameRight = characterNameRight;
        this.dialogTextRight = dialogTextRight;
        this.dialogBackground = dialogBackground;
    }

    public string GetCharacterNameRight()
    {
        return characterNameRight;
    }
    public string GetDialogTextRight()
    {
        return dialogTextRight;
    }

}


public class DialogManager : MonoBehaviour
{
    private static DialogManager Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.LogError("Multiple instances of DialogManager found!");
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        InitDialogs();
    }

    public static DialogManager GetInstance()
    {
        return Instance;
    }

    [SerializeField]
    private DialogUI dialogUI;
    [SerializeField]
    private DialogSplitUI dialogSplitUI;

    private List<DialogSequence> dialogSequences = new List<DialogSequence>();//���жԻ�����

    private DialogSequence currentDialogSequence;//��ǰ�Ի�����
    private int currentSequenceID;
    private int currentDialogSequenceSize;//��ǰ�Ի������м���Ի�
    private int nextDialogSequenceID;//��ǰ�Ի����н��������һ��Ի����У�Ҳ�ɲ��ã�ֱ��ָ���ض��Ի����Ҳ��������ȥ��


    private int currentDialogIndex;//��ǰ�Ի������еڼ���Ի�

    public bool isInSplitDialog = false;

    //�����һ��json�ļ�ר�����þ���
    private void InitDialogs() {
        //For test
        StoryData.Init();
        dialogSequences = StoryData.dialogSequences;
    }

    public void PlayDialogSequence(int dialogSequenceID) {
        currentDialogIndex = 0;
        currentSequenceID = dialogSequenceID;
        currentDialogSequence = dialogSequences[dialogSequenceID];
        currentDialogSequenceSize = currentDialogSequence.GetSize();
        nextDialogSequenceID = currentDialogSequence.GetNextSequenceID();
        NextDialog();
    }

    public void PlayNextDialogSequence()
    {
        currentDialogIndex = 0;
        currentSequenceID = nextDialogSequenceID;
        currentDialogSequence = dialogSequences[nextDialogSequenceID];
        currentDialogSequenceSize = currentDialogSequence.GetSize();
        nextDialogSequenceID = currentDialogSequence.GetNextSequenceID();
        NextDialog();
    }

    public void NextDialog()
    {
        if (!isInSplitDialog)
        {
            if (currentDialogIndex < currentDialogSequenceSize)
            {
                Dialog currentDialog = currentDialogSequence.GetNextDialog();
                if (dialogUI != null)
                {
                    dialogUI.SetDialog(currentDialog.GetCharacterName(),
                        currentDialog.GetDialogText(), currentDialog.GetDialogBackground());
                    currentDialogIndex++;
                }
            }
            else
            {
                UIManager.GetInstance().CloseDialogPanel();
                MainGameManager.GetInstance().SwitchState(currentDialogSequence.nextState);
            }
        }
        else {
            if (currentDialogIndex < currentDialogSequenceSize)
            {
                DialogSplit currentDialog = (DialogSplit)currentDialogSequence.GetNextDialog();
                if (dialogSplitUI != null)
                {
                    dialogSplitUI.SetDialog(currentDialog.GetCharacterName(),
                        currentDialog.GetDialogText(), currentDialog.GetCharacterNameRight(),
                        currentDialog.GetDialogTextRight(), currentDialog.GetDialogBackground());
                    currentDialogIndex++;
                }
            }
            else
            {
                UIManager.GetInstance().CloseDialogPanel();
                MainGameManager.GetInstance().SwitchState(currentDialogSequence.nextState);
            }
        }
       
    }


    public int GetSaveInfo() {

        return currentSequenceID;
    }

    public void SetSequenceID(int id)
    {
        currentDialogIndex = 0;
        currentSequenceID = id;
        currentDialogSequence = dialogSequences[id];
        currentDialogSequenceSize = currentDialogSequence.GetSize();
        nextDialogSequenceID = currentDialogSequence.GetNextSequenceID();
    }

}
