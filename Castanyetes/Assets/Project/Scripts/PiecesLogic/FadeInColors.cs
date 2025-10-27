using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class FadeInColors : MonoBehaviour
{
    [SerializeField] private CanvasGroup initialPiece;
    [SerializeField] private CanvasGroup secondPiece;
    [SerializeField] private CanvasGroup middlePiece;
    [SerializeField] private CanvasGroup fourthPiece;
    [SerializeField] private CanvasGroup finalPiece;
    [SerializeField] private GameObject win;
    [SerializeField] private float fadeOpacity = 0.66f;
    private bool fadeIn = false;
    private bool fadeOut = false;
    private bool fadeInImage = true;
    private int counter;

    public void ShowElement()
    {
        fadeIn = true;
    }
    public void AddCounter()
    {
        counter++;
    }

    private void Start()
    {
        initialPiece.alpha = 0;
        finalPiece.alpha = 0;
        secondPiece.alpha = 0;
        fourthPiece.alpha = 0;
        middlePiece.alpha = 0;
        counter = 1;
    }

    private void Update()
    {
        if (fadeIn)
        {
            if (initialPiece.alpha < fadeOpacity && counter == 1)
            {
                initialPiece.alpha += Time.deltaTime;
            }
            else if (secondPiece.alpha < fadeOpacity && counter == 2)
            {
                secondPiece.alpha += Time.deltaTime;
            }
            else if (middlePiece.alpha < fadeOpacity && counter == 3)
            {
                middlePiece.alpha += Time.deltaTime;
            }
            else if (fourthPiece.alpha < fadeOpacity && counter == 4)
            {
                fourthPiece.alpha += Time.deltaTime;
            }
            else if (finalPiece.alpha < fadeOpacity && counter == 5)
            {
                finalPiece.alpha += Time.deltaTime;
            }

            if (initialPiece.alpha >= fadeOpacity && counter == 1)
            {
                AddCounter();
                fadeIn = false;
            }
            else if (secondPiece.alpha >= fadeOpacity && counter == 2)
            {
                AddCounter();
                fadeIn = false;
            }
            else if (middlePiece.alpha >= fadeOpacity && counter == 3)
            {
                AddCounter();
                fadeIn = false;
            }
            else if (fourthPiece.alpha >= fadeOpacity && counter == 4)
            {
                AddCounter();
                fadeIn = false;
            }
            else if (finalPiece.alpha >= fadeOpacity && counter == 5)
            {
                AddCounter();
                fadeIn = false;
            }
        }
        if (!fadeIn && counter == 6)
        {
            win.SetActive(true);
            win.GetComponent<StarsController>().LevelFinished();
        }
    }
}
