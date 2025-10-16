using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class FadeInColors : MonoBehaviour
{
    [SerializeField] private CanvasGroup initialPiece;
    [SerializeField] private CanvasGroup secondPiece;
    [SerializeField] private CanvasGroup middlePiece;
    [SerializeField] private CanvasGroup fourthPiece;
    [SerializeField] private CanvasGroup finalPiece;
    [SerializeField] private float fadeOpacity = 0.66f;
    private bool fadeIn = false;
    private bool fadeOut = false;
    private bool fadeInImage = true;

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
        finalPiece.alpha = 0;
        secondPiece.alpha = 0;
        fourthPiece.alpha = 0;
        middlePiece.alpha = 0;
    }

    private void Update()
    {
        if (fadeIn)
        {
            if (initialPiece.alpha < fadeOpacity && finalPiece.alpha < fadeOpacity)
            {
                initialPiece.alpha += Time.deltaTime;
                finalPiece.alpha += Time.deltaTime;
            }
            if (initialPiece.alpha >= fadeOpacity / 3 && secondPiece.alpha < fadeOpacity && fourthPiece.alpha < fadeOpacity)
            {
                secondPiece.alpha += Time.deltaTime;
                fourthPiece.alpha += Time.deltaTime;
            }
            if (secondPiece.alpha >= fadeOpacity / 3 && middlePiece.alpha < fadeOpacity)
            {
                middlePiece.alpha += Time.deltaTime;
                if (middlePiece.alpha >= fadeOpacity)
                {
                    fadeIn = false;
                }
            }

        }

        if (fadeOut)
        {
            if (initialPiece.alpha > 0 && finalPiece.alpha > 0)
            {
                initialPiece.alpha -= Time.deltaTime;
                finalPiece.alpha -= Time.deltaTime;
            }
            if (initialPiece.alpha <= fadeOpacity - (fadeOpacity / 3) && secondPiece.alpha > 0 && fourthPiece.alpha > 0)
            {
                secondPiece.alpha -= Time.deltaTime;
                fourthPiece.alpha -= Time.deltaTime;
            }
            if (secondPiece.alpha <= fadeOpacity - (fadeOpacity / 3) && middlePiece.alpha > 0)
            {
                middlePiece.alpha -= Time.deltaTime;
                if (middlePiece.alpha == 0)
                {
                    fadeOut = false;
                }
            }
        }
    }


    public void FadeThisImage(CanvasGroup image)
    {
        fadeInImage = true;

        if (fadeInImage)
        {
            if (image.alpha < fadeOpacity)
            {
                middlePiece.alpha += Time.deltaTime;
                if (middlePiece.alpha >= fadeOpacity)
                {
                    fadeInImage = false;
                }
            }
        }
    }
}
