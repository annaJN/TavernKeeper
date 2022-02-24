using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 
using Yarn.Unity;

public class DropItem : MonoBehaviour, IDropHandler
{
    private InMemoryVariableStorage variableStorage;
    private Inventory inventory;
    public int conditionItem; //the item the character/object wants
    public void Start() {
        variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
        inventory = GameObject.FindGameObjectWithTag("gameManager").GetComponent<Inventory>();
    }    
    public void OnDrop(PointerEventData eventData){
        Debug.Log("OnDrop");
        GameObject foodItem = eventData.pointerDrag;
        //check if it's the right order (only one item for now)
        if (foodItem.GetComponent<Serveable>().id == conditionItem){
            inventory.setFull(foodItem.GetComponent<Serveable>().slotindex, false); //sets the food item's inventory slot to empty
            GameObject.Destroy(foodItem); //destroys the food item
            variableStorage.SetValue("$gregDialog", 2); //sätter variabel i yarn
        }
    }

    [YarnCommand("SetOrder")]
    public void SetOrder(int id){
        conditionItem = id;
    }

}
