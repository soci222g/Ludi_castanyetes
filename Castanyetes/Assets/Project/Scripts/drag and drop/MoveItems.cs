using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveItems : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    
   
    
    private float startPosX, startPosY;

    private Value Piece_value;


    [SerializeField] private float snapPuzzle = 1.5f;

    [SerializeField] private List<GameObject> correctForm;

    private void Start()
    {
        Piece_value = GetComponent<Value>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        startPosX = mousePos.x - this.transform.position.x;
        startPosY = mousePos.y - this.transform.position.y;

     
        Debug.Log("Moving");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        for (int i = 0; i < correctForm.Count; i++)
        {
            if (Mathf.Abs(this.transform.position.x - correctForm[i].transform.position.x) <= snapPuzzle &&
                Mathf.Abs(this.transform.position.y - correctForm[i].transform.position.y) <= snapPuzzle)
            {
                this.transform.position = correctForm[i].transform.position;

                //enviar dato del objeto
                correctForm[i].GetComponent<reciveInfo>().setPice_Value(Piece_value.GetNum());
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        this.gameObject.transform.position = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.position.z);
    }
}
