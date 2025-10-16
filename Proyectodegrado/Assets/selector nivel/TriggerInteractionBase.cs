using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteractionBase : MonoBehaviour, Interactable
{
    private object UserInput;

    public GameObject Player { get; set; }
    public bool CanInteract { get; set ; }
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (CanInteract)
        {
            if (UserInput.WasInteractPressed)
            {
                Interact();
            }
        }
    }
    private void OiggerEnter2D(Collider2D collision)
    {
        
     if (collision.gameObject== Player)
           {
            CanInteract = true;
        }   }
    public virtual void Interact()
    { }
    private void OnTriggerExit2D(Collider2D collision)
    {
       if (collision.gameObject== Player)
           {
            CanInteract = false;
        }   
    }
}
