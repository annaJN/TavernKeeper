using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{

    private Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindObjectWithTag("Player").GetComponent<Inventory>();
        //Should not be player, should be something else that we add to our GameManager

    }

    void onTriggerEnter2D(Colloder2D other) {
        if (other.CompareTag("Player")){
            for (int i = 0; i < inventory.slots.Lenght; i++)
            {
                if(inventory.isFull[i] == false){
                    //then the item can be added to the inventory
                    inventory.isFull[i] = true;
                    break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
