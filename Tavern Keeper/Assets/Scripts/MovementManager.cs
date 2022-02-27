using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class MovementManager : MonoBehaviour
{
    public GameObject Button_toTavern;
    private DialogueRunner dialogueRunner;
    public void Start() {
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
    }

    //move back to tavern
    public void ToTavern(){
        if (!dialogueRunner.IsDialogueRunning) {
            Camera.main.transform.position = new Vector3(8, -4.5f, -10); //move camera to tavern
            Button_toTavern.SetActive(false); //make back-button non-visible
        }
    }

    //move camera to kitchen
    public void ToBarKitchen(){
        Camera.main.transform.position = new Vector3(28, -4.5f, -10);
        Button_toTavern.SetActive(true); //make back-button visible
    }

    //move to a table. Should be changed to move to several tables
    public void ToTable1(){
        Camera.main.transform.position = new Vector3(48, -4.5f, -10);
        Button_toTavern.SetActive(true); //make back-button visible
    }
        public void ToTable2(){
        Camera.main.transform.position = new Vector3(48, -14.5f, -10);
        Button_toTavern.SetActive(true); //make back-button visible
    }
        public void ToTable3(){
        Camera.main.transform.position = new Vector3(48, -24.5f, -10);
        Button_toTavern.SetActive(true); //make back-button visible
    }
}
