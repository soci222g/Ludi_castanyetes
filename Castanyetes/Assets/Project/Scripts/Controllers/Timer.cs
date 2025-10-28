using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
        [SerializeField] private GameObject win;
    private float elapsedTime;
    private bool isRunning = false;

    private void Start()
    {
        timerText.text = "02:30";
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2"))
        {
            Resume();
            elapsedTime = 150f;
            isRunning = true;
        }
    }

    public void StartTimer()
    {
        Resume();
        elapsedTime = 150f;
        isRunning = true;
    }

    void Update()
    {
        if (isRunning)
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
    }

    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Resume()
    {
            Time.timeScale = 1f;
    }

    public void PauseAndResume()
    {
        if (Time.timeScale > 0f)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
        
    public static string GetActualTimer()
    {
        return GameObject.FindObjectOfType<Timer>().timerText.text;
    }
    

}

