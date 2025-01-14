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

    private List<DialogSequence> dialogSequences = new List<DialogSequence>();//���жԻ�����

    private DialogSequence currentDialogSequence;//��ǰ�Ի�����
    private int currentDialogSequenceSize;//��ǰ�Ի������м���Ի�
    private int nextDialogSequenceID;//��ǰ�Ի����н��������һ��Ի����У�Ҳ�ɲ��ã�ֱ��ָ���ض��Ի����Ҳ��������ȥ��


    private int currentDialogIndex;//��ǰ�Ի������еڼ���Ի�


    //�����һ��json�ļ�ר�����þ���
    private void InitDialogs() {
        //For test
        DialogSequence s1 = new DialogSequence(0,1, GameState.SceneGame);
        s1.AddDialog(new Dialog("С��", "�š��ţ������ģ�������Ķ�����׼�����ˡ�"));
        s1.AddDialog(new Dialog("С��", "�϶����кܺõĳ��ֵġ�"));
        s1.AddDialog(new Dialog("С��", "��������ô���˻���绰���ʺ�������Ϣ��"));
        s1.AddDialog(new Dialog("С��", "�����������õģ���һ��ע�����塣"));
        dialogSequences.Add(s1);

        DialogSequence s2 = new DialogSequence(1, 2, GameState.SceneGame);
        s2.AddDialog(new Dialog("С��", "����ȵ�����һ�¡���"));
        s2.AddDialog(new Dialog("С��", "����֪������ʲô����"));
        s2.AddDialog(new Dialog("С��", "��������׻�ƴһƴ�¡���"));
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
