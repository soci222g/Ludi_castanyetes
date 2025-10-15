using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class FadeInColors : MonoBehaviour
{
    [SerializeField] private CanvasGroup myElement;
    [SerializeField] private bool fadeIn = false;
    [SerializeField] private bool fadeOut = false;
    [SerializeField] private float fadeOpacity = 0.5f;
    public void ShowElement()
    {
        fadeIn = true;
    }
    public void HideElement()
    {
        fadeOut = true;
    }

    private void Start()
    {
        myElement.alpha = 0;
    }

    private void Update()
    {
        if (fadeIn)
        {
            if (myElement.alpha < fadeOpacity)
            {
                myElement.alpha += Time.deltaTime;
                if (myElement.alpha >= fadeOpacity)
                {
                    fadeIn = false;
                }
            }
        }

        if (fadeOut)
        {
            if (myElement.alpha > 0)
            {
                myElement.alpha -= Time.deltaTime;
                if (myElement.alpha == 0)
                {
                    fadeOut = false;
                }
            }
        }
    }
}
