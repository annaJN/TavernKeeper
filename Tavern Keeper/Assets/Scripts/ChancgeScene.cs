using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChancgeScene : MonoBehaviour
{
    Renderer rend;
    public string ChangeSceneToID; //To make the changes work for all our objects 

    //public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
        //camera = Camera.main;
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){

        rend.material.color = Color.red;
        SceneManager.LoadScene (sceneName:ChangeSceneToID);
    }

}
