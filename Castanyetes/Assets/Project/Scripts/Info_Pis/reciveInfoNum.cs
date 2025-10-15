using System;
using UnityEngine;

public class reciveInfoNum : MonoBehaviour
{
    

   
     [SerializeField] private char TextElement;

    [SerializeField] private ManagerLevelNum manager;

    [SerializeField] private int piss_Number;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        TextElement = ' ';
    }

   
    public void setPice_Value(char value)
    {
    
        TextElement = value;



        manager.setElemetns(TextElement, piss_Number);

    }
}
