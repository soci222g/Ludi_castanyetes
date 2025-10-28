using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private float duration = 1f;
    [SerializeField] private string targetSceneName;

    void Start()
    {
        // Make sure we have a canvas group
        if (canvasGroup == null)
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }

        // Start by fading in from black
        StartCoroutine(StartFadeIn());
    }

    IEnumerator StartFadeIn()
    {
        // Start completely black
        canvasGroup.alpha = 1f;

        // Fade to clear
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
        // Fade to black
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