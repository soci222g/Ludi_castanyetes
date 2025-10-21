using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class scoreManager : MonoBehaviour
{
    private int currentCastanyetesSaved = 0;
    private int castanyetesTotal = 50;
    [SerializeField] private int castanyetesSavedXLevel = 5;
    [SerializeField] TextMeshProUGUI castanyetesText;

    private void Awake()
    {
        currentCastanyetesSaved = PlayerPrefs.GetInt("Castanyetes");
    }

    void Start()
    {
        castanyetesText.text = PlayerPrefs.GetInt("Castanyetes", 0).ToString() + " / " + castanyetesTotal;
    }

    public void LevelCompletedInNewWay()
    {
        PlayerPrefs.SetInt("Castanyetes", currentCastanyetesSaved + castanyetesSavedXLevel);
    }
}
