using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ManagerLevelString : MonoBehaviour
{
    [SerializeField] private List<string> WordList = new List<string>();
    [SerializeField] private int numBoxes;



    private List<char> ListChars = new List<char>();

    private resetElements resElements;
    [SerializeField] private bafaradaScreep bafarada;

    [SerializeField] private AudioSource CorrectAudio;
    [SerializeField] private AudioSource badAudio;


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
        for (int i = 0; i < WordList.Count; i++)
        {
            if (WordList[i] == FinalWord)
            {
                CorrectAudio.Play();
                bafarada.deleteElement(FinalWord);
                WordList.RemoveAt(i);
                GetComponent<FadeInColors>().ShowElement();
                resElements.ResetItems();
                return;
            }
            
        }
        for (int i = 0; i < ListChars.Count; i++)
        {
            if (ListChars[i] == ' ')
            {
                return;
            }
        }
        badAudio.Play();
    }
    
    public List<string> GetListOfWords()
        { return WordList; }

}
