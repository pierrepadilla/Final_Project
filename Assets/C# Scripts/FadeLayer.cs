using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]

public class FadeLayer : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] bool startFadedOut = false;
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = startFadedOut ? 1 : 0;
    }

    public IEnumerator ChangeAlphaOverTime(float alpha, float time)
    {
        float currentAlpha = canvasGroup.alpha;
        float elapsed = 0f;
        while (elapsed < time)
        {
            var factor = elapsed / time;
            canvasGroup.alpha = Mathf.Lerp(currentAlpha, alpha, factor);
            yield return null;
            elapsed += Time.deltaTime;
        }
        canvasGroup.alpha = alpha;
    }
}
