using UnityEngine;
using UnityEngine.UI;

public class SolutionBox : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private controlerMovement controlerMov;

    private void Start()
    {
        controlerMov.swapActiveElement();
    }

    public void UnPauseWhileAnim()
    {
        timer.StartTimer();
        controlerMov.swapActiveElement();
    }
}
