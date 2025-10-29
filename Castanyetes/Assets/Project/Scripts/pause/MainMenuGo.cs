using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuGo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void CanviarEscena(string name)
    {
        SceneManager.LoadScene(name);
    }
}
