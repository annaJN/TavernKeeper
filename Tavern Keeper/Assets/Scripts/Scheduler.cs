using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using Yarn.Unity;

public class Scheduler : MonoBehaviour
{
    public GameObject charTemplate;
    public GameObject[] places;
    public Text moneyCounter; 
    public int money; 
    void Awake(){
        //EnterChar("Greg", places[1]);
    }

    [YarnCommand("EnterChar")]
    public void EnterChar(string charName, GameObject location){ //Instantiates character and changes its Name, conversation Start Node, and Image based on charName
        GameObject character = Instantiate(charTemplate, location.transform, false);
        character.name = charName;
        character.GetComponent<YarnInteractable>().conversationStartNode = charName;

        Sprite sprite = Resources.Load<Sprite>("Characters/" + charName);
        character.GetComponent<SpriteRenderer>().sprite = sprite;

        character.transform.parent.GetChild(0).GetComponent<Image>().sprite = sprite; //sets sprite in tavern
        character.transform.parent.GetChild(0).GetComponent<Image>().color = new Color(255, 255, 255, 1f); 

    }

    [YarnCommand("LeaveChar")]
    public void LeaveChar(GameObject character){
        character.transform.parent.GetChild(0).GetComponent<Image>().sprite = null; //sets sprite in tavern
        character.transform.parent.GetChild(0).GetComponent<Image>().color = new Color(255, 255, 255, 0f); 
        GameObject.Destroy(character);
    }

    [YarnCommand("GetMoney")]
    public void GetMoney(int incomingMoney){
        money += incomingMoney; 
        moneyCounter.text = money.ToString(); 
    }
    
}
