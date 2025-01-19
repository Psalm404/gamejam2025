using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPieceCounter : MonoBehaviour

{
    // Start is called before the first frame update
    public static LightPieceCounter Instance;
    public CanvasGroup ImageGroup;
    public int pieceCount = 0;
    public int totalCount = 4;
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
       
        if (pieceCount == totalCount)
        {
            
            StartCoroutine(FadeInAndOut());

        }
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(1.5f);
        MiniGameManager.GetInstance().FinishMinigame("LightJigsaw");
    }

    IEnumerator FadeInAndOut()
    {
        Debug.Log("fade");
        float fadeDuration = 1f;
        float timeElapsed = 0f;

        while (timeElapsed < fadeDuration)
        {
            ImageGroup.alpha = Mathf.Lerp(0f, 1f, timeElapsed / fadeDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        ImageGroup.alpha = 1f;
        StartCoroutine(Pause());

    }
}

