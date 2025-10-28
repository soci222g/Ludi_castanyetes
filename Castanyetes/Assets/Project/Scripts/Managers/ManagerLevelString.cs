using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ManagerLevelString : MonoBehaviour
{
    [SerializeField] private List<string> WordList = new List<string>();
    [SerializeField] private int numBoxes;



    private List<char> ListChars = new List<char>();

    private resetElements resElements;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < numBoxes; i++)
        {
            ListChars.Add(' ');
        }
        resElements = GetComponent<resetElements>();
    }

    public void setElemetns(char GetElements, int place)
    {


        ListChars[place - 1] = GetElements;


        CheckResult();
    }

    public void CheckResult()
    {
        string FinalWord = "";

     

        FinalWord = new string(ListChars.ToArray());

        Debug.Log(FinalWord);
        for (int i = 0; i < WordList.Count; i++) {
            if (WordList[i] == FinalWord) {
                WordList.RemoveAt(i);
                GetComponent<FadeInColors>().ShowElement(); 
                resElements.ResetItems();
            }

        }



    }


}
