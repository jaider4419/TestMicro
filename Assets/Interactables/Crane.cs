using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crane : Interactable
{
    [SerializeField]
    private GameObject CraneHinge;
    private bool IsMoving;
    private bool hasBeenPressed = false; // Flag to track if the button has been pressed
    public AudioSource audiosource;

    protected override void Interact()
    {
        // Check if the button has already been pressed
        if (!hasBeenPressed)
        {
            Debug.Log("Opened");
            IsMoving = !IsMoving;
            CraneHinge.GetComponent<Animator>().SetBool("IsMoving", IsMoving);
            audiosource.Play();

            // Set the flag to indicate that the button has been pressed
            hasBeenPressed = true;
        }
    }
}

