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

public class DialogSequence //中间没有任何其他交互的一组对话
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

    private List<DialogSequence> dialogSequences = new List<DialogSequence>();//所有对话序列

    private DialogSequence currentDialogSequence;//当前对话序列
    private int currentSequenceID;
    private int currentDialogSequenceSize;//当前对话序列有几组对话
    private int nextDialogSequenceID;//当前对话序列结束后的下一组对话序列（也可不用，直接指定特定对话编号也可以跳过去）


    private int currentDialogIndex;//当前对话序列中第几句对话

    public bool isInSplitDialog = false;

    //可另存一个json文件专门配置剧情
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
