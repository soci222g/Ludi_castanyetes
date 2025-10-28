using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveItems : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    
   private Vector2 m_Position;
    
    private float startPosX, startPosY;

    private Value Piece_value;

    

    [SerializeField] private float snapPuzzle = 1.5f;

    [SerializeField] private List<GameObject> correctForm;

    private void Start()
    {
        Piece_value = GetComponent<Value>();
        m_Position = new Vector2(transform.position.x, transform.position.y);
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

   

        for (int i = 0; i < correctForm.Count; i++)
        { 
            if(this.transform.position == correctForm[i].transform.position)
            {
                correctForm[i].GetComponent<reciveInfoNum>().resetPiceValue();
            }
        }

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        for (int i = 0; i < correctForm.Count; i++)
        {
            if (Mathf.Abs(this.transform.position.x - correctForm[i].transform.position.x) <= snapPuzzle &&
                Mathf.Abs(this.transform.position.y - correctForm[i].transform.position.y) <= snapPuzzle)
            {
                if (!correctForm[i].GetComponent<reciveInfoNum>().GetPlacerObject())
                {
                    this.transform.position = correctForm[i].transform.position;

                    //enviar dato del objeto
                    if (correctForm[i].GetComponent<reciveInfoNum>())
                        correctForm[i].GetComponent<reciveInfoNum>().setPice_Value(Piece_value.GetLeter());
                }
               
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

    public void initialPos()
    {
        transform.position = m_Position;
    }
}
