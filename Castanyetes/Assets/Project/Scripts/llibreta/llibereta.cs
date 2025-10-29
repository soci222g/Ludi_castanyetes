using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class llibereta : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private List<TextMeshProUGUI> TextList;
    
    public void SetTextCorrecto(string text,bool stringManager)
    {
        for (int i = 0; i < TextList.Count; i++) {
            if (TextList[i].text == " ") {
                if (stringManager) {
                    TextList[i].text = "c" + text + "a";
                    return;
                }
                
                TextList[i].text = text;
                return;
            }
        }
    }
}
