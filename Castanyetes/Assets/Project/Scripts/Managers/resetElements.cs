using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;



public class resetElements : MonoBehaviour
{



    [SerializeField] private List<MoveItems> itemsPlace = new List<MoveItems>();

    [SerializeField] private List<reciveInfoNum> boxes = new List<reciveInfoNum>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created



    private IEnumerator soptToReturnPices()
    {
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < itemsPlace.Count; i++)
        {
            itemsPlace[i].initialPos();
        }
        for (int i = 0; i < boxes.Count; i++)
        {
            boxes[i].resetPiceValue();
        }
    }


    public void ResetItems()
    {
        StartCoroutine(soptToReturnPices());
    }


    
}
