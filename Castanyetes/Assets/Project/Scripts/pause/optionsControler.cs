using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class optionsControler : MonoBehaviour
{

    [SerializeField]
    private AudioMixer audioMixer;
    [SerializeField]
    private string grup;
    private Slider slider;
    [SerializeField]
 


    private void Awake()
    {
        slider = GetComponent<Slider>();

    }

 
    public void SetVolume()
    {
        audioMixer.SetFloat(grup, Mathf.Log10(slider.value) * 80f);
    }
}
