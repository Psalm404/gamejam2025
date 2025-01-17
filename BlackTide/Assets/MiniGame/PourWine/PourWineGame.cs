using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PourWineGame : MonoBehaviour
{
    public GameObject Arrow;
    public GameObject Ruler;
    public GameObject RulerLine;
    public GameObject Pour;
    public GameObject PlacedBottle;
    public GameObject Wine;

    private bool movingUp = true;
    private bool isMoving = true;
    public float speed;

    private float rulerTop;
    private float rulerBottom;

    private CanvasGroup placedBottleGroup;
    private CanvasGroup pourGroup;
    private CanvasGroup wineGroup;
    public UnityEngine.UI.Image screenOverlay; // 用来做屏幕变暗的遮罩层

    // Start is called before the first frame update
    void Start()
    {
        placedBottleGroup = PlacedBottle.GetComponent<CanvasGroup>();
        pourGroup = Pour.GetComponent<CanvasGroup>();
        wineGroup = Wine.GetComponent<CanvasGroup>();

        pourGroup.alpha = 0f;
        wineGroup.alpha = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        MoveArrow();
        if (isMoving)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("getmousedown in redwine");
                bool isSuccess = CheckSuccess();
                if (isSuccess)
                {
                    StartCoroutine(FadeOutAndIn());
                }
                else
                {
                    StartCoroutine(FadeScreen());

                    
                }
            }
        }
        if (pourGroup.alpha == 1f && wineGroup.alpha == 0f)
        {
            Debug.Log("start fade in wine");
            StartCoroutine(FadeInWine());
        }

        if (wineGroup.alpha == 1f)
        {
            StartCoroutine(Pause());
        }
    }

    private void MoveArrow()
    {
        if (isMoving)
        {

            RectTransform rulerRect = Ruler.GetComponent<RectTransform>();
            Vector3[] corners = new Vector3[4];
            rulerRect.GetWorldCorners(corners);

            rulerTop = corners[1].y; // 左上角 Y 坐标
            rulerBottom = corners[0].y; // 左下角 Y 坐标


            // Move the arrow up and down
            Vector3 arrowPosition = Arrow.transform.position;
            if (arrowPosition.y >= rulerTop)
            {
                movingUp = false;
            }
            if (arrowPosition.y <= rulerBottom)
            {
                movingUp = true;
            }
            if (movingUp)
            {
                arrowPosition.y += speed * Time.deltaTime;
            }
            else
            {
                arrowPosition.y -= speed * Time.deltaTime;

            }

            Arrow.transform.position = arrowPosition;
        }
    }

    private bool CheckSuccess()
    {
        isMoving = false;
        // Get the RulerLine's bounds
        RectTransform rulerLineRect = RulerLine.GetComponent<RectTransform>();
        Vector3[] lineCorners = new Vector3[4];
        rulerLineRect.GetWorldCorners(lineCorners);
        float rulerLineTop = lineCorners[1].y;
        float rulerLineBottom = lineCorners[0].y;
        Debug.Log("rulerLine" + rulerLineTop + rulerLineBottom);

        RectTransform arroweRect = Arrow.GetComponent<RectTransform>();
        Vector3[] arrowCorners = new Vector3[4];
        arroweRect.GetWorldCorners(arrowCorners);
        float arrowTop = arrowCorners[1].y;
        float arrowBottom = arrowCorners[0].y;

        float arrowCenter = (arrowTop + arrowBottom) / 2f;
        Debug.Log(arrowCenter);

        // Check if the Arrow is within the RulerLine's range
        if (arrowCenter >= rulerLineBottom && arrowCenter <= rulerLineTop)
        {
            Debug.Log("Success! The arrow is within the RulerLine range.");


            return true;
        }
        else
        {

            return false;
        }
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(1.5f);
        MiniGameManager.GetInstance().FinishMinigame("PourWine");
    }

    IEnumerator PauseForTwoSeconds()
    {
        yield return new WaitForSeconds(1f);

    }


    IEnumerator FadeOutAndIn()
    {

        float fadeDuration = 1f;
        float timeElapsed = 0f;

        while (timeElapsed < fadeDuration)
        {
            placedBottleGroup.alpha = Mathf.Lerp(1f, 0f, timeElapsed / fadeDuration);
            pourGroup.alpha = Mathf.Lerp(0f, 1f, timeElapsed / fadeDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }


        placedBottleGroup.alpha = 0f;
        pourGroup.alpha = 1f;
    }

    IEnumerator FadeInWine()
    {

        float fadeDuration = 1f;
        float timeElapsed = 0f;

        while (timeElapsed < fadeDuration)
        {
            wineGroup.alpha = Mathf.Lerp(0f, 1f, timeElapsed / fadeDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }

        wineGroup.alpha = 1f;
    }

    IEnumerator FadeScreen()
    {
        // 使屏幕变暗
        yield return StartCoroutine(FadeTo(1f)); // 变暗
        Vector3 arrowPosition = Arrow.transform.position;
        arrowPosition.y = rulerBottom;
        Arrow.transform.position = arrowPosition;
        // 立即进行变亮
        yield return StartCoroutine(FadeTo(0f)); // 变亮

        
        isMoving = true;
    }

    IEnumerator FadeTo(float targetAlpha)
    {
        float duration = 1f; // 渐变持续时间
        float startAlpha = screenOverlay.color.a;

        float timeElapsed = 0f;

        while (timeElapsed < duration)
        {
            timeElapsed += Time.deltaTime;
            float alpha = Mathf.Lerp(startAlpha, targetAlpha, timeElapsed / duration);
            Color color = screenOverlay.color;
            color.a = alpha;
            screenOverlay.color = color;
            yield return null;
        }

        // 确保完全变成目标透明度
        Color finalColor = screenOverlay.color;
        finalColor.a = targetAlpha;
        screenOverlay.color = finalColor;
    }
}