using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 
using Yarn.Unity;

public class DropItem : MonoBehaviour, IDropHandler
{
    private InMemoryVariableStorage variableStorage;
    private DialogueRunner dialogueRunner;
    private Inventory inventory;
    public int conditionItem; //the item the character/object wants
    public void Start() {
        variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
        inventory = GameObject.FindGameObjectWithTag("gameManager").GetComponent<Inventory>();
    }    
    public void OnDrop(PointerEventData eventData){
        GameObject foodItem = eventData.pointerDrag;
        //check if it's the right order (only one item for now)
        if (dialogueRunner.IsDialogueRunning){ //can´t serve when dialog is running
            return;
        }
        if (foodItem.GetComponent<Serveable>().id == conditionItem){
            inventory.setFull(foodItem.GetComponent<Serveable>().slotindex, false); //sets the food item's inventory slot to empty
            GameObject.Destroy(foodItem); //destroys the food item
            YarnInteractable interactable = gameObject.GetComponent<YarnInteractable>(); //interactable is the yarn script/object on the character
            if (interactable != null){ //should be subclass for characters but whatever
                string serveVariable = "$" + gameObject.name + "Served";
                variableStorage.SetValue(serveVariable, 1); //sätter variabel i Yarn
                interactable.OnMouseDown(); //startar konversation
            }
        }
    }

    [YarnCommand("SetOrder")]
    public void SetOrder(int id){
        conditionItem = id;
    }

}
