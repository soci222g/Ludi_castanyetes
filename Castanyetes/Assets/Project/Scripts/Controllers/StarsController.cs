using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class StarsController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI totalTimerText;
    [SerializeField] Image star1;
    [SerializeField] Image star2;
    [SerializeField] Image star3;
    [SerializeField] Image Notstar1;
    [SerializeField] Image Notstar2;
    [SerializeField] Image Notstar3;
    [SerializeField] Image titoHappy;
    [SerializeField] Image titoSad;

    private string timer;

    void Start()
    {
        titoHappy.enabled = false;
        titoSad.enabled = false;
        star1.enabled = false;
        star2.enabled = false;
        star3.enabled = false;
        Notstar1.enabled = false;
        Notstar2.enabled = false;
        Notstar3.enabled = false;
    }

    public void LevelFinished()
    {
        timer = Timer.GetActualTimer();
        totalTimerText.text = timer;

        if (timer.CompareTo("00:30") <= 0)
        {
            star1.enabled = true;
            star2.enabled = true;
            star3.enabled = true;
            titoHappy.enabled = true;
        }
        else if (timer.CompareTo("00:45") <= 0)
        {
            star1.enabled = true;
            star2.enabled = true;
            Notstar3.enabled = true;
            titoHappy.enabled = true;
        }
        else if (timer.CompareTo("01:00") <= 0)
        {
            star1.enabled = true;
            Notstar2.enabled = true;
            Notstar3.enabled = true;
            titoHappy.enabled = true;
        }
        else
        {
            Notstar1.enabled = true;
            Notstar2.enabled = true;
            Notstar3.enabled = true;
            titoSad.enabled = true;
        }
    }
}
