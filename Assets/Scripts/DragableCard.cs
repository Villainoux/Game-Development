using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragableCard : MonoBehaviour,IBeginDragHandler , IDragHandler, IEndDragHandler
{
    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.position; // Store the original position.
    }

    public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("OnBeginDrag");
    
    
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");

        this.transform.position = eventData.position;

    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");

        this.transform.position = originalPosition;

    }
}
