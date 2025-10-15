using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class FadeInColors : MonoBehaviour
{
    [SerializeField] private CanvasGroup initialPiece;
    [SerializeField] private CanvasGroup finalPiece;
    [SerializeField] private CanvasGroup secondPiece;
    [SerializeField] private CanvasGroup middlePiece;
    [SerializeField] private CanvasGroup fourthPiece;
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
        initialPiece.alpha = 0;
    }

    private void Update()
    {
        if (fadeIn)
        {
            if (initialPiece.alpha < fadeOpacity)
            {
                initialPiece.alpha += Time.deltaTime;
                if (initialPiece.alpha >= fadeOpacity)
                {
                    fadeIn = false;
                }
            }
        }

        if (fadeOut)
        {
            if (initialPiece.alpha > 0)
            {
                initialPiece.alpha -= Time.deltaTime;
                if (initialPiece.alpha == 0)
                {
                    fadeOut = false;
                }
            }
        }
    }
}
