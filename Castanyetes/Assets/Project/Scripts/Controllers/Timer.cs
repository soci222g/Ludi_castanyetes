using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
        [SerializeField] private GameObject win;
    private float elapsedTime;

    void Start()
    {
        Resume();
        elapsedTime = 150f;
        timerText.text = "02:30";
    }

    void Update()
    {
        elapsedTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (timerText.text == "00:00")
        {
            win.SetActive(true);
            win.GetComponent<StarsController>().LevelFailed();
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }

    public static string GetActualTimer()
    {
        return GameObject.FindObjectOfType<Timer>().timerText.text;
    }
    

}

