using System;
using UnityEngine;

public class reciveInfoNum : MonoBehaviour
{
    

    [SerializeField] private int pice_Value;
    [SerializeField] private char TextElement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pice_Value = 0;
        TextElement = ' ';
    }

   
    public void setPice_Value(char value)
    {
    
        TextElement = value;

        pice_Value = (int)TextElement;
    }
}
