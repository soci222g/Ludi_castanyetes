using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private float duration = 1f;
    private string targetSceneName;

    void Start()
    {
        StartCoroutine(StartFadeIn());
    }

    IEnumerator StartFadeIn()
    {
        canvasGroup.alpha = 1f;

        float timer = 0f;
        while (timer < duration)
        {
            timer += Time.deltaTime;
            canvasGroup.alpha = 1f - (timer / duration);
            yield return null;
        }

        canvasGroup.alpha = 0f;
    }

    public void LoadScene(string sceneName)
    {
        targetSceneName = sceneName;
        StartCoroutine(FadeOutAndLoad());
    }

    IEnumerator FadeOutAndLoad()
    {
        float timer = 0f;
        while (timer < duration)
        {
            timer += Time.deltaTime;
            canvasGroup.alpha = timer / duration;
            yield return null;
        }

        canvasGroup.alpha = 1f;

        SceneManager.LoadScene(targetSceneName);
    }
}