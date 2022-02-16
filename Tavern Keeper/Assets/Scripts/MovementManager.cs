using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    public GameObject Button_toTavern;

    //move back to tavern
    public void ToTavern(){
        Camera.main.transform.position = new Vector3(8, -4.5f, -10); //move camera to tavern
        Button_toTavern.SetActive(false); //make back-button non-visible
    }

    //move camera to kitchen
    public void ToBarKitchen(){
        Camera.main.transform.position = new Vector3(28, -4.5f, -10);
        Button_toTavern.SetActive(true); //make back-button visible
    }

    //move to a table. To be changed when we add more tables
    public void ToTable(){
        Camera.main.transform.position = new Vector3(48, -4.5f, -10);
        Button_toTavern.SetActive(true); //make back-button visible
    }

    public void test(){
        Debug.Log("You've pressed table");
    }
}
