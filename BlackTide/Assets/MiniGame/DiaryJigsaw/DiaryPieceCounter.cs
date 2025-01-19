using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryPieceCounter : MonoBehaviour

{
    // Start is called before the first frame update
    public static DiaryPieceCounter Instance;
    public int pieceCount = 0;
    public int totalCount = 6;
    public CanvasGroup diaryGroup;
    void Start()
    {
        
    }

    void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);  
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckSuccess();
    }

    public void CheckSuccess()
    {
        Debug.Log(pieceCount);
        if (pieceCount == totalCount)
        {
            
            StartCoroutine(FadeInAndOut());

        }
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(1.5f);
        MiniGameManager.GetInstance().FinishMinigame("DiaryJigsaw");
    }

    IEnumerator FadeInAndOut()
    {
        Debug.Log("fade");
        float fadeDuration = 1.3f;
        float timeElapsed = 0f;

        while (timeElapsed < fadeDuration)
        {
            diaryGroup.alpha = Mathf.Lerp(0f, 1f, timeElapsed / fadeDuration);
            
            timeElapsed += Time.deltaTime;
            yield return null;
        }

        diaryGroup.alpha = 1f;
        StartCoroutine(Pause());

    }
}

