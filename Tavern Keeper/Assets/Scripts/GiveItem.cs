using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GiveItem : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler//, IDropHandler
{

    private Canvas canvas; 
    private Inventory inventory;
    public bool isDragging;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("DragNDrop").GetComponent<Canvas>();
        //inventory = GameObject.FindGameObjectWithTag("gameManager").GetComponent<Inventory>(); // Gamemanager is the one holding our inventory
        //Button btn = this.GetComponent<Button>();
        //btn.onClick.AddListener(onMouseDown);   
    }
    private void Awake(){
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData){
        Debug.Log("OnBeginDrag");
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData){
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData){
        Debug.Log("OnEndDrag");
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData){
        Debug.Log("OnPointerDown");
    }


//Below is not used right now

    void SelectFoodOnClick(){
        //Debug.Log("thingy clicked on :)");

    }

    void GiveFoodOnClick(){
        //inventory.setFull(i, false);
        //Destroy(gameObject); 
    }
}
