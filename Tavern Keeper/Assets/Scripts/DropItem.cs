using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 
using Yarn.Unity;

public class DropItem : MonoBehaviour, IDropHandler
{
    private InMemoryVariableStorage variableStorage;
    private Inventory inventory;
    public void Start() {
        variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
        inventory = GameObject.FindGameObjectWithTag("gameManager").GetComponent<Inventory>();
    }    
    public void OnDrop(PointerEventData eventData){
        Debug.Log("OnDrop");
        //check if it's the right order
        inventory.setFull(eventData.pointerDrag.GetComponent<Serveable>().slotindex, false); //sets the food item's inventory slot to empty
        GameObject.Destroy(eventData.pointerDrag); //destroys the food item
        variableStorage.SetValue("$gregDialog", 2); //sätter variabel i yarn
    }

}
