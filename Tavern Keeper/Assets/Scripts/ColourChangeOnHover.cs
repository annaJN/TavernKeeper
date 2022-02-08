using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChangeOnHover : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer rend;
    void Start()
    {
         rend = GetComponent<Renderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    


    // The mesh goes red when the mouse is over it...
    void OnMouseEnter()
    {
        rend.material.color = Color.red;
    }


    // ...and the mesh finally turns white when the mouse moves away.
    void OnMouseExit()
    {
        rend.material.color = Color.white;
    }
}
