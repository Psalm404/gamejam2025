using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicAnimation : MonoBehaviour
{
    public static IEnumerator FadeIn(Image sprite, float fadeInTime)
    {
        float duration = fadeInTime;
        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / duration;
            sprite.color = new Color(1, 1, 1, Mathf.Lerp(0, 1, t));
            yield return null;
        }
        sprite.color = new Color(1, 1, 1, 1);
    }

    public static IEnumerator FadeOut(Image sprite, float fadeOutTime)
    {
        float duration = fadeOutTime;
        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / duration;
            sprite.color = new Color(1, 1, 1, Mathf.Lerp(1, 0, t));
            yield return null;
        }
        sprite.color = new Color(1, 1, 1, 0);
    }

   
}
