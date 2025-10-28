using System;
using UnityEngine;

public class reciveInfoNum : MonoBehaviour
{

    private bool placedObject;
   
     [SerializeField] private char TextElement;

    [SerializeField] private ManagerLevelNum Num;
    [SerializeField] private ManagerLevelString str;

    [SerializeField] private int piss_Number;

    private ParticleSystem ps;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placedObject = false;
        TextElement = ' ';
        ps = GetComponentInChildren<ParticleSystem>();
    }


    public bool GetPlacerObject() { return placedObject; }
    public void setPice_Value(char value)
    {
    
        TextElement = value;
        placedObject = true;
        ps.Play();
        if (Num != null) 
        Num.setElemetns(TextElement, piss_Number);


        if(str != null)
            str.setElemetns(TextElement, piss_Number);


        
    }

    public void resetPiceValue()
    {
        TextElement = ' ';
        placedObject = false;

        if (Num != null)
            Num.setElemetns(TextElement, piss_Number);


        if (str != null)
            str.setElemetns(TextElement, piss_Number);


       
    }
}
