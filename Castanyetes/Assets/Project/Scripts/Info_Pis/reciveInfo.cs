using System;
using UnityEngine;

public class reciveInfo : MonoBehaviour
{
    

    [SerializeField] private int pice_Value;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pice_Value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setPice_Value(int value)
    {
        pice_Value = value;
    }
}
