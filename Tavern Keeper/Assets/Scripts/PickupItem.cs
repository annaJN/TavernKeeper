using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupItem : MonoBehaviour
{

    private Inventory inventory;
    public GameObject itemButton;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("gameManager").GetComponent<Inventory>(); // Gamemanager is the one holding our inventory
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(GetFoodOnClick);
    }

    void GetFoodOnClick() {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if(inventory.isEmpty(i)){
                //then the item can be added to the inventory
                inventory.setFull(i, true); //since inventory is private we call this setter function
                Instantiate(itemButton, inventory.slots[i].transform, false);
                break;
            }
        }
    }

}
