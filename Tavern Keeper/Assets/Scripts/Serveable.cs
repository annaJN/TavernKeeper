using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Serveable : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler//, IDropHandler
{

    private Canvas canvas; 
    //private Inventory inventory;
    public bool isDragging;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public int slotindex;
    public int id; //beer is 1, soup should be 2

    void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("DragNDrop").GetComponent<Canvas>();
    }
    private void Awake(){
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData){
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData){
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData){
        canvasGroup.blocksRaycasts = true;
        rectTransform.anchoredPosition = new Vector2(0,0); //resets position. Needs to be negated if dragged elsewhere
    }
}
