using System;
using UnityEngine;

public class reciveInfoNum : MonoBehaviour
{
    

   
     [SerializeField] private char TextElement;

    [SerializeField] private ManagerLevelNum Num;
    [SerializeField] private ManagerLevelString str;

    [SerializeField] private int piss_Number;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        TextElement = ' ';
    }

   
    public void setPice_Value(char value)
    {
    
        TextElement = value;

        if(Num != null) 
        Num.setElemetns(TextElement, piss_Number);


        if(str != null)
            str.setElemetns(TextElement, piss_Number);
        
    }
}
