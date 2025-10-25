using UnityEngine;

public class controlerMovement : MonoBehaviour
{
    [SerializeField] private MoveItems[] move;

    public void swapActiveElement()
    {
        
        for (int i = 0; i < move.Length; i++) {
            if (move[i].enabled) { 
                move[i].enabled = false;
            
            }
            else {
                move[i].enabled = true; 
            
            }




        }

    }
}
