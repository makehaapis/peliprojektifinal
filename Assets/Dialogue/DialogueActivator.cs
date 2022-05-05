using UnityEngine;

public class DialogueActivator : MonoBehaviour, Interactable
{
    [SerializeField] private DialogueObject dialogueObject;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out PlayerDialog playerdialog))
        {
            playerdialog.interactable = this;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out PlayerDialog playerdialog))
        {
            if (playerdialog.interactable is DialogueActivator dialogueActivator && dialogueActivator == this)
            {
                playerdialog.interactable = null;
            }
        }
    }

    public void Interact(PlayerDialog playerdialog)
    {
        playerdialog.DialogueUI.ShowDialogue(dialogueObject);
    }
}
