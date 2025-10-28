using UnityEngine;

public class TimeBafarada : MonoBehaviour
{

    [SerializeField]private float currentTime = 0;
    private float TotalTime = 20.0f;

    private bafaradaScreep bafarada;
    private bool hasRandomElement = true;

    void Start()
    {
        bafarada = GetComponent<bafaradaScreep>();
        ResetTimerBafarada();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime >= 0)
        {
            currentTime -= Time.deltaTime;
        }
        else
        {
            if (hasRandomElement)
            {
                bafarada.GetRandomImage();
                hasRandomElement = false;
            }
        }

    }

   
    public void ResetTimerBafarada()
    {
        currentTime = TotalTime;
        hasRandomElement = true;
    }
}
