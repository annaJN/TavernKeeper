using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //Defining two variables
    private bool[] isFull;
    public GameObject[] slots;

    public bool isEmpty(int index){
        return !isFull[index]; //Inverting to give true if it is empty
    }

    public void setFull(int i, bool b){
        isFull[i] = b;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Assigning isFull with a new instance of an array with the same lenght as slots
        isFull = new bool[slots.Length];        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
