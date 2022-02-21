using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnInteractable : MonoBehaviour {
    // internal properties exposed to editor
    [SerializeField] private string conversationStartNode;

    // internal properties not exposed to editor
    private DialogueRunner dialogueRunner;
    private bool interactable = true;
    private bool isCurrentConversation = false;
    private float defaultIndicatorIntensity;

    public void Start() {
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
        dialogueRunner.onDialogueComplete.AddListener(EndConversation);
    }

    public void OnMouseDown() {
        if (interactable && !dialogueRunner.IsDialogueRunning) {
            StartConversation();
        }
    }

// disable scene interaction, activate speaker indicator, and
// run dialogue from {conversationStartNode}
    private void StartConversation() {
        Debug.Log($"Started conversation with {name}.");
        isCurrentConversation = true;
        dialogueRunner.StartDialogue(conversationStartNode);
    }

    
// reverse StartConversation's changes: 
// re-enable scene interaction, deactivate indicator, etc.
    private void EndConversation() {
        if (isCurrentConversation) {
            isCurrentConversation = false;
            Debug.Log($"Ended conversation with {name}.");
        }
    }

//    [YarnCommand("disable")]
// make character not able to be clicked on
    public void DisableConversation() {
        interactable = false;
    }
}