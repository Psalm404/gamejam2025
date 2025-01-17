using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BubbleClickGame : SceneGameBase
{
    [SerializeField]
    private Button heart;
    private int heartClickCount = 0;

    [SerializeField]
    private Animator BubblePanelAni;

    [SerializeField]
    private Button Paper;


    [SerializeField]
    private List<Button> ThoughtBubbles = new List<Button>();
    [SerializeField]
    private GameObject Thought_1;
    [SerializeField]
    private GameObject Thought_2;
    [SerializeField]
    private GameObject Thought_3;

    private int BubbleClickCount = 0;

    private int state = 0;

    public override void StartPlay()
    {
        if (state == 0) {
            BubblePanelAni.gameObject.SetActive(false);
            Paper.gameObject.SetActive(false);
            Thought_1.SetActive(false);
            Thought_2.SetActive(false);
            Thought_3.SetActive(false);
            foreach (Button b in ThoughtBubbles) {
                Button tempB = b;
                b.onClick.AddListener(() => OnThoughtBubbleClick(tempB));
            }
        }
        else if (state == 2) {
            Paper.gameObject.SetActive(true);
        }
        else if (state == 3)
        {
            Thought_1.gameObject.SetActive(true);
        }

    }


    private int thoughtBubbleCount = 0;
    public void OnThoughtBubbleClick(Button b) {
        thoughtBubbleCount++;
        b.gameObject.SetActive(false);//破碎动画
        if (state == 3) {
            if (thoughtBubbleCount == 3) {
                Thought_1.gameObject.SetActive(false);
                Thought_2.gameObject.SetActive(true);
                state = 4;
                thoughtBubbleCount = 0;
            }
        }else if (state == 4)
        {
            if (thoughtBubbleCount == 10)
            {
                Thought_2.gameObject.SetActive(false);
                Thought_3.gameObject.SetActive(true);
                state = 5;
                thoughtBubbleCount = 0;
            }
        }else if (state == 5)
        {
            if (thoughtBubbleCount == 10)
            {
                Thought_3.gameObject.SetActive(false);
                MainGameManager.GetInstance().SwitchState(GameState.SceneGame);
            }
        }

    }


    public void ClickBubble() {
        BubbleClickCount++;
        if (BubbleClickCount == 9) {
            MainGameManager.GetInstance().StartDialogSequence(201);
            state = 2;
        }
    }

    public void OnPaperClick() {
        //Paper.GetComponent<Image>().sprite = Resources.Load<Sprite>("");
        //播放动画收集黑水
        Paper.gameObject.SetActive(false);
        MainGameManager.GetInstance().StartDialogSequence(202);
        state = 3;
        
    }

    public void OnHeartClick()
    {
        heartClickCount++;
        if (heartClickCount == 1) {
            //heart.GetComponent<Image>().sprite = Resources.Load<Sprite>("");
            heart.GetComponent<RectTransform>().localScale = new Vector3(1.5f, 1.5f, 1);
        }
        else if (heartClickCount == 2)
        {
            //heart.GetComponent<Image>().sprite = Resources.Load<Sprite>("");
            heart.GetComponent<RectTransform>().localScale = new Vector3(2f, 2f, 1);
        }
        else if (heartClickCount == 3)
        {
            //破碎动画
            BubblePanelAni.gameObject.SetActive(true);
            BubblePanelAni.SetTrigger("HeartBroken");
            heart.gameObject.SetActive(false);
            //等动画播完
            MainGameManager.GetInstance().StartDialogSequence(200);
            state = 1;
            //heart.GetComponent<RectTransform>().localScale = new Vector3(2f, 2f, 1);
        }

    }

}
