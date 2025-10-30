using UnityEngine;

public class Cinematic : MonoBehaviour
{
    [SerializeField] private GameObject win;
    public void EndOfCinematic()
    {
        win.SetActive(true);
        win.GetComponent<StarsController>().LevelFinished();
    }
}
