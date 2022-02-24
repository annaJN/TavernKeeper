using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Test : MonoBehaviour
{
    private InMemoryVariableStorage variableStorage;
    public void Start() {
        variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
    }


    public void Serve()
    {
        variableStorage.SetValue("$gregDialog", 2);
    }
}
