using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Scheduler : MonoBehaviour
{
    public GameObject charTemplate;
    // Start is called before the first frame update
    void Start(){
        
    }

    [YarnCommand("EnterChar")]
    public void EnterChar(string charName, Vector3 location){ //we need to fgure location out :)
        Instantiate(charTemplate, location, Quaternion.identity); //vet inte om Quaternion funkar så

    }
    
}
