using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class bafaradaScreep : MonoBehaviour
{
    [SerializeField] private ManagerLevelString manager;
    [SerializeField] private List<Sprite> SpriteDibujo = new List<Sprite>();
    private Dictionary<string, Sprite> mapBafarades = new Dictionary<string, Sprite>();


   [SerializeField] private Image ReferenceBafarada;
   [SerializeField] private Image ImageToPutReference;
                    private TimeBafarada timer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        ReferenceBafarada.enabled = false;  
           

        ImageToPutReference.enabled = false;
        timer = GetComponent<TimeBafarada>();
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
        timer.ResetTimerBafarada();
    }

    public void GetRandomImage()
    {

        int randomNum = manager.GetListOfWords().Count;

        randomNum = Random.Range(0, randomNum - 1);

        for(int i = 0;i < manager.GetListOfWords().Count; i++)
        {
            if(randomNum == i)
           activate(mapBafarades.ElementAt(i).Key);
        }
    }

    public void activate(string element)
    {
        ReferenceBafarada.enabled = true;
        ImageToPutReference.sprite = mapBafarades[element];

        ImageToPutReference.enabled = true;

    }

}
