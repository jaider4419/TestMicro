using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoor : Interactable
{
    [SerializeField]
    private GameObject ElevatorDoorO;
    private bool ElevatorOpen;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void Interact()
    {
        audioSource.Play();
        Debug.Log("Opened");
        ElevatorOpen = !ElevatorOpen;
        ElevatorDoorO.GetComponent<Animator>().SetBool("IsOpen", ElevatorOpen);

    }
}