using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Canvas CanvasObject; // Assign in inspector
    private bool isShowing;

    public void buttonpress(){
        Debug.Log("You've pressed button");
    }

    public void DisableCanvas() {
        Debug.Log("You've pressed button");
        isShowing = !isShowing;
        CanvasObject.enabled = isShowing;
    }

}