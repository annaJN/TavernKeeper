using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using Yarn.Unity;

public class Scheduler : MonoBehaviour
{
    public GameObject charTemplate;
    public GameObject place;
    void Awake(){
        EnterChar("Greg", place);
    }

    [YarnCommand("EnterChar")]
    public void EnterChar(string charName, GameObject location){ //Instantiates character and changes its Name, conversation Start Node, and Image based on charName
        GameObject character = Instantiate(charTemplate, location.transform, false);
        character.name = charName;
        character.GetComponent<YarnInteractable>().conversationStartNode = charName;
        Sprite sprite = Resources.Load<Sprite>("Images/" + charName);
        character.GetComponent<Image>().sprite = sprite;
    }
    
}
