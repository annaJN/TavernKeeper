using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Canvas CanvasObject; // Assign in inspector
    public bool isShowing;

    void Start()
    {
        CanvasObject.enabled = isShowing;
    }

    public void ToggleCanvas() {
        Debug.Log("You've pressed button");
        isShowing = !isShowing;
        CanvasObject.enabled = isShowing;
    }

}