using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 
using Yarn.Unity;

public class ItemHoming : MonoBehaviour, IDropHandler
{
    private InMemoryVariableStorage variableStorage;
    public void Start() {
        variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
    }    
    public void OnDrop(PointerEventData eventData){
        Debug.Log("OnDrop");
        GameObject.Destroy(eventData.pointerDrag);
        variableStorage.SetValue("$gregDialog", 2);
    }

}
