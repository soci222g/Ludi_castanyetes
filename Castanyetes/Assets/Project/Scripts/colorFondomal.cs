using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorFondomal : MonoBehaviour
{

    [SerializeField] private List<CanvasGroup> fondos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < fondos.Count; i++)
        {
            fondos[i].alpha = 0;
        }
    }

    private IEnumerator resetElement()
    {
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < fondos.Count; i++)
        {
            fondos[i].alpha = 0;
        }
    }


    public void activateElements()
    {
        for (int i = 0; i < fondos.Count; i++)
        {
            fondos[i].alpha = 0.5f;
        }
        StartCoroutine(resetElement());
    }


  
}
