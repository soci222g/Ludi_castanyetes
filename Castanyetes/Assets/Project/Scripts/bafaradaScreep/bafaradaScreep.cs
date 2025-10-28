using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bafaradaScreep : MonoBehaviour
{
    [SerializeField] private ManagerLevelString manager;
    [SerializeField] private List<Image> SpriteDibujo = new List<Image>();
    private Dictionary<string, Image> mapBafarades;


    private Image ReferenceBafarada;
    private Image ImageToPutReference;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      ReferenceBafarada = GetComponent<Image>();
        ReferenceBafarada.enabled = false;  
           
        ImageToPutReference = GetComponentInChildren<Image>();
        ImageToPutReference.enabled = false;
        initializeImage();
    }

    private void initializeImage()
    {
       List<string> CurrentWords = manager.GetListOfWords();
        for (int i = 0; i < CurrentWords.Count; i++) {
            mapBafarades.Add(CurrentWords[i], SpriteDibujo[i]);
        }
    }

    public void deleteElement(string element)
    {
       if (mapBafarades.ContainsKey(element))
       {
            mapBafarades.Remove(element);
       }
        ImageToPutReference.enabled = false;
        ReferenceBafarada.enabled = false;

    }

    public void GetRandomImage()
    {
        int randomNum = manager.GetListOfWords().Count;
    }

    public void activate(string element)
    {
        ReferenceBafarada.enabled = true;
        ImageToPutReference = mapBafarades[element];

        ImageToPutReference.enabled = true;

    }

}
