using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ManagerLevelNum : MonoBehaviour
{

    [SerializeField] private int finalNum;

    [SerializeField] private int numBoxes;

    [SerializeField] private GameObject win;

    private List<char> ListChars = new List<char>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        for (int i = 0; i < numBoxes; i++) {
            ListChars.Add(' ');
        }

    }



    public void setElemetns(char GetElements, int place){
      

        ListChars[place - 1] = GetElements;

        calculateResult();

    }

    private void calculateResult()
    {
        List<int> numberElements = new List<int>();
        numberElements.Add(0);

        int numEquacions = 0;

        int result = 0;

        List<int>OperadorCode = new List<int>();
    

        for (int i = 0; i < ListChars.Count; i++) {



            switch (ListChars[i])
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
                    if(ListChars[i] != ' ')
                        numberElements[numEquacions] = numberElements[numEquacions]*10 + (int)ListChars[i] - 48;

                    break;

            }
            
        }


        if(numEquacions == 0)
        {
            result = numberElements[0];
        }
        for (int i = 0; numEquacions > i; i++) {

            switch (OperadorCode[i])
            {
                case 1:
                    result += numberElements[i];
                    break;
                case 2:
                    result -= numberElements[i];
                    break;
                case 3:
                    result *= numberElements[i];
                    break;
            }
            if (i == 0)
            {
                result = numberElements[i];
            }

        }



        Debug.Log(result);
        CheckResult(result);
    }

    private void CheckResult(int calcul)
    {
        if(calcul == finalNum)
        {
            win.SetActive(true);
        }
    }
  

}
