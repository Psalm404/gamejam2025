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
    private string characterName;
    private string dialogText;

    public Dialog(string characterName, string dialogText) {
        this.characterName = characterName;
        this.dialogText = dialogText;
    }

    public string GetCharacterName() {
        return characterName;
    }
    public string GetDialogText()
    {
        return dialogText;
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

    private List<DialogSequence> dialogSequences = new List<DialogSequence>();//所有对话序列

    private DialogSequence currentDialogSequence;//当前对话序列
    private int currentDialogSequenceSize;//当前对话序列有几组对话
    private int nextDialogSequenceID;//当前对话序列结束后的下一组对话序列（也可不用，直接指定特定对话编号也可以跳过去）


    private int currentDialogIndex;//当前对话序列中第几句对话


    //可另存一个json文件专门配置剧情
    private void InitDialogs() {
        //For test
        DialogSequence s1 = new DialogSequence(0,1, GameState.SceneGame);
        s1.AddDialog(new Dialog("小夫", "嗯、嗯，您放心，我明天的东西都准备好了。"));
        s1.AddDialog(new Dialog("小夫", "肯定会有很好的呈现的。"));
        s1.AddDialog(new Dialog("小夫", "辛苦您这么晚了还打电话来问候，您快休息。"));
        s1.AddDialog(new Dialog("小夫", "哈……哈，好的，我一定注意身体。"));
        dialogSequences.Add(s1);

        DialogSequence s2 = new DialogSequence(1, 2, GameState.SceneGame);
        s2.AddDialog(new Dialog("小夫", "刚想喝点麻醉一下……"));
        s2.AddDialog(new Dialog("小夫", "我哪知道该做什么……"));
        s2.AddDialog(new Dialog("小夫", "拿往年的套话拼一拼呗……"));
        dialogSequences.Add(s2);
    }

    public void PlayDialogSequence(int dialogSequenceID) {
        currentDialogIndex = 0;
        currentDialogSequence = dialogSequences[dialogSequenceID];
        currentDialogSequenceSize = currentDialogSequence.GetSize();
        nextDialogSequenceID = currentDialogSequence.GetNextSequenceID();
        NextDialog();
    }

    public void PlayNextDialogSequence()
    {
        currentDialogIndex = 0;
        currentDialogSequence = dialogSequences[nextDialogSequenceID];
        currentDialogSequenceSize = currentDialogSequence.GetSize();
        NextDialog();
    }

    public void NextDialog()
    {
        if (currentDialogIndex < currentDialogSequenceSize)
        {
            Dialog currentDialog = currentDialogSequence.GetNextDialog();
            if (dialogUI != null) {
                dialogUI.SetDialog(currentDialog.GetCharacterName(), currentDialog.GetDialogText());
                currentDialogIndex++;
            }
        }
        else
        {
            dialogUI.gameObject.SetActive(false);
            MainGameManager.GetInstance().SwitchState(currentDialogSequence.nextState);
        }
    }


    public int GetSaveInfo() {

        return currentDialogSequence.GetSequenceID();
    }

    public void SetSequenceID(int id)
    {
        currentDialogIndex = 0;
        currentDialogSequence = dialogSequences[id];
        currentDialogSequenceSize = currentDialogSequence.GetSize();
        nextDialogSequenceID = currentDialogSequence.GetNextSequenceID();
    }

}
