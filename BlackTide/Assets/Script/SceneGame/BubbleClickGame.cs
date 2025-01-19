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
    private GameObject FullBox;

    [SerializeField]
    private List<Button> ThoughtBubbles = new List<Button>();
    [SerializeField]
    private GameObject Thought_1;
    [SerializeField]
    private GameObject Thought_2;
    [SerializeField]
    private GameObject Thought_3;

    [SerializeField]
    private GameObject Thought_1_1;
    [SerializeField]
    private GameObject Thought_2_1;
    [SerializeField]
    private GameObject Thought_3_1;

    [SerializeField]
    private GameObject water;

    [SerializeField]
    private List<GameObject> Thought1Bubbles = new List<GameObject>();

    [SerializeField]
    private List<GameObject> Thought2Bubbles = new List<GameObject>();

    [SerializeField]
    private List<GameObject> Thought3Bubbles = new List<GameObject>();

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
            AudioManager.GetInstance().heartBeat.Play();
        }
        else if (state == 2) {
            Paper.gameObject.SetActive(true);
        }
        else if (state == 3)
        {
            Thought_1.gameObject.SetActive(true);
            MainGameManager.GetInstance().StartDialogSequence(203);
            state = 4;
        }

    }


    private int thoughtBubbleCount = 0;
    public void OnThoughtBubbleClick(Button b) {
        thoughtBubbleCount++;
        b.gameObject.transform.GetChild(0).gameObject.SetActive(false);

        StartCoroutine(BubbleBrokenAnimation(b.GetComponent<Image>()));

        if (state == 4) {
            if (thoughtBubbleCount == 3) {
                StartCoroutine(BasicAnimation.FadeOut(Thought_1.GetComponent<Image>(), 2));
                StartCoroutine(BasicAnimation.FadeIn(Thought_1_1.GetComponent<Image>(), 2));

                foreach (GameObject o in Thought1Bubbles) {
                    StartCoroutine(ThoughtAnimation(o, Thought_1, Thought_2));
                }
                state = 5;
                thoughtBubbleCount = 0;
            }
        }else if (state == 5)
        {
            if (thoughtBubbleCount == 10)
            {
                StartCoroutine(BasicAnimation.FadeOut(Thought_2.GetComponent<Image>(), 2));
                StartCoroutine(BasicAnimation.FadeIn(Thought_2_1.GetComponent<Image>(), 2));

                foreach (GameObject o in Thought2Bubbles)
                {
                    StartCoroutine(ThoughtAnimation(o, Thought_2, Thought_3));
                }
                state = 6;
                thoughtBubbleCount = 0;
            }
        }else if (state == 6)
        {
            if (thoughtBubbleCount == 10)
            {
                StartCoroutine(BasicAnimation.FadeOut(Thought_3.GetComponent<Image>(), 2));
                StartCoroutine(BasicAnimation.FadeIn(Thought_3_1.GetComponent<Image>(), 2));

                foreach (GameObject o in Thought3Bubbles)
                {
                    StartCoroutine(ThoughtAnimation(o, Thought_3));
                }
               
            }
        }

    }

    public void ClickBubble(Image i) {
        AudioManager.GetInstance().bubbleCrash2.Play();
        StartCoroutine(BubbleBrokenAnimation(i));
        BubbleClickCount++;
        if (BubbleClickCount == 9) {
            StartCoroutine(BasicAnimation.FadeIn(water.GetComponent<Image>(), 1));
            MainGameManager.GetInstance().StartDialogSequence(201);
            state = 2;
        }
    }

    private int paperFlag = 0;
    public void OnPaperClick() {
        if (paperFlag == 0)
        {
            Paper.GetComponent<Image>().sprite = Resources.Load<Sprite>("Level1/b1");
            paperFlag = 1;
        }
        else {
            Paper.GetComponent<Button>().interactable = false;
            StartCoroutine(BoxCollectAnimation());
        }
        
    }

    public void OnHeartClick()
    {
        heartClickCount++;
        if (heartClickCount == 1) {
            AudioManager.GetInstance().heartBeat.Stop();
            AudioManager.GetInstance().heartSwell.Play();
            heart.GetComponent<Animator>().enabled = false;
            heart.GetComponent<Image>().sprite = Resources.Load<Sprite>("Level1/h2");
        }
        else if (heartClickCount == 2)
        {
            AudioManager.GetInstance().heartToBubble.Play();
            heart.GetComponent<Image>().sprite = Resources.Load<Sprite>("Level1/h3");
        }
        else if (heartClickCount == 3)
        {
            AudioManager.GetInstance().bubbleCrash2.Play();
            StartCoroutine(HeartBrokenAnimation(heart.GetComponent<Image>()));
            state = 1;           
        }

    }

    private float frameInterval = 0.1f;
    private IEnumerator HeartBrokenAnimation(Image image)
    {   int i = 0;
        while (i<6)
        {
            i++;
            image.sprite = Resources.Load<Sprite>("Level1/" + i);
            yield return new WaitForSeconds(frameInterval);
        }
        heart.gameObject.SetActive(false);
        BubblePanelAni.gameObject.SetActive(true);
        BubblePanelAni.SetTrigger("HeartBroken");
    }

    private IEnumerator BubbleBrokenAnimation(Image image)
    {
        int i = 0;
        while (i < 6)
        {
            i++;
            image.sprite = Resources.Load<Sprite>("Level1/" + i);
            yield return new WaitForSeconds(frameInterval);
        }
        image.gameObject.SetActive(false);
    }

    private IEnumerator BoxCollectAnimation()
    {
        float elapsedTime = 0.0f;
        float duration = 3.0f;

        StartCoroutine(BasicAnimation.FadeOut(water.GetComponent<Image>(), 2));
        StartCoroutine(BasicAnimation.FadeIn(FullBox.GetComponent<Image>(), 2));

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        Paper.gameObject.SetActive(false);
        MainGameManager.GetInstance().StartDialogSequence(202);
        state = 3;
    }


    private IEnumerator ThoughtAnimation(GameObject o,GameObject ToInactive,GameObject ToActive)
    {
        Vector2 startPosition = o.GetComponent<RectTransform>().anchoredPosition; // 初始位置
        Vector2 targetPosition = startPosition + new Vector2(0, 50); // 目标位置

        float elapsedTime = 0.0f;
        float duration = 3.0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime; 
            float t = elapsedTime / duration; 
            o.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(startPosition, targetPosition, t);
            yield return null;
        }
        ToInactive.SetActive(false);
        if (ToActive != null) {
            ToActive.SetActive(true);
            if (ToActive == Thought_3) {
                AudioManager.GetInstance().laugh.Play();
            }
        }
    }

    private IEnumerator ThoughtAnimation(GameObject o, GameObject ToInactive)
    {
        Vector2 startPosition = o.GetComponent<RectTransform>().anchoredPosition; // 初始位置
        Vector2 targetPosition = startPosition + new Vector2(0, 50); // 目标位置

        float elapsedTime = 0.0f;
        float duration = 4.0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;
            o.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(startPosition, targetPosition, t);
            yield return null;
        }
        ToInactive.SetActive(false);
        MainGameManager.GetInstance().SwitchState(GameState.SceneGame);
    }
}
