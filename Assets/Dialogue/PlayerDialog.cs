using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialog : MonoBehaviour
{
    [SerializeField] private TMPController dialogueUI;
    public TMPController DialogueUI => dialogueUI;
    public Interactable interactable { get; set; }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (interactable != null)
            {
                interactable.Interact(this);
            }
        }
    }
}
