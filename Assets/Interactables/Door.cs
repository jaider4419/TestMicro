using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    [SerializeField]
    private GameObject RoomDoor;
    private bool doorOpen;
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
        Debug.Log("Opened?");
        doorOpen = !doorOpen;
        RoomDoor.GetComponent<Animator>().SetBool("IsOpen", doorOpen);

    }
}
