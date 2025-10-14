using UnityEngine;

public class Value : MonoBehaviour
{

    [SerializeField] private int Num;

    [SerializeField] private char leter;
  
    public int GetNum() { return Num; }
    public char GetLeter() { return leter; }
    
}
