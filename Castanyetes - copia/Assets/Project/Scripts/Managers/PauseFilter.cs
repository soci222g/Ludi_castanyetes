using UnityEngine;

public class PauseFilter : MonoBehaviour
{
    public void SetActiveState()
    {
        if (gameObject.active)
            gameObject.SetActive(false);
        else
            gameObject.SetActive(true);
    }
}
