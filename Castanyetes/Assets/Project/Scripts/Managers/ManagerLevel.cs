using NUnit.Framework;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ManagerLevelNum : MonoBehaviour
{

    [SerializeField] private int finalNum;

    [SerializeField] private int numBoxes;


    private List<char> listChars = new List<char>();

    private List<string> saveSolutions = new List<string>();


    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        for (int i = 0; i < numBoxes; i++) {
            listChars.Add(' ');
        }

    }



    public void setElemetns(char GetElements, int place){
      

        listChars[place - 1] = GetElements;

        calculateResult();

    }

    private void calculateResult()
    {
        List<int> numberElements = new List<int>();
        numberElements.Add(0);

        int numEquacions = 0;

        int result = 0;

        List<int>OperadorCode = new List<int>();
    

        for (int i = 0; i < listChars.Count; i++) {



            switch (listChars[i])
            {
                
                case '+':
                        numEquacions++;
                        numberElements.Add(0);
                        OperadorCode.Add(1);
                    break;
                case '-':
                        numEquacions++;
                        numberElements.Add(0);
                        OperadorCode.Add(2);

                        break;
                case 'X':
                        numEquacions++;
                        numberElements.Add(0);
                        OperadorCode.Add(3);

                        break;
                default:
                    if(listChars[i] != ' ')
                        numberElements[numEquacions] = numberElements[numEquacions]*10 + (int)listChars[i] - 48;
                    
                    break;

            }
            
        }

       
            
        
        if(numEquacions == 0)
        {
            result = numberElements[0];
        }
        for (int i = 0; numEquacions > i; i++) {
            if (i == 0)
            {
                result = numberElements[i];
            }
            switch (OperadorCode[i])
            {
                case 1:
                    result += numberElements[i + 1];
                    break;
                case 2:
                    result -= numberElements[i + 1];
                    break;
                case 3:
                    result *= numberElements[i + 1];
                    break;
            }
           

        }



        Debug.Log(result);
        CheckResult(result);
    }

    private void CheckResult(int calcul)
    {
        if(calcul == finalNum)
        {
            GetComponent<FadeInColors>().ShowElement();

            string FinalWord = "";

            FinalWord = new string(listChars.ToArray());

            checkcalculation(FinalWord);

        }
    }
  
    private void checkcalculation(string solution)
    {
        if(saveSolutions.Count == 0)
        {
            saveSolutions.Add(solution);
        }
        for(int i = 0; i < saveSolutions.Count; i++)
        {
            
            if(solution == saveSolutions[i])
            {

            }
        }

    }

}
