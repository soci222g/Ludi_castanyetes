using NUnit.Framework;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ManagerLevelNum : MonoBehaviour
{

    [SerializeField] private int finalNum;

    [SerializeField] private int numBoxes;
    [SerializeField] private List<int> numsUsed;
    [SerializeField] private int numCorrectAnser;
 
    private List<char> listChars = new List<char>();


    


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

        List<int> numUsedOrdened = new List<int>(numberElements);
        

        numUsedOrdened.Sort();
        



        if (numEquacions == 0)
        {
            result = numberElements[0];
        }
        for (int i = 0; numEquacions > i; i++) {
            if(i == 0)
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
       
        CheckResult(result, numUsedOrdened);
    }

    private void CheckResult(int calcul, List<int> numUsedOrdened)
    {

        if (calcul == finalNum)
        {
            CheckNumAreCorrect(numUsedOrdened);
          
        }
    }

    private void CheckNumAreCorrect(List<int> numUsedOrdened)
    {
        int numMaix = 0;
        for(int i = 0; i < numUsedOrdened.Count; i++)
        {
            numMaix = numMaix*10 + numUsedOrdened[i];
        }
   
        for (int i = 0; i < numsUsed.Count; i++) {
            if (numsUsed[i] == numMaix)
                return;
            
        }
        numsUsed.Add(numMaix);
        finalResuit();
    }
    private void finalResuit()
    {
        if (numsUsed.Count >= numCorrectAnser)
        {
            GetComponent<FadeInColors>().ShowElement();
        }
    }

}
