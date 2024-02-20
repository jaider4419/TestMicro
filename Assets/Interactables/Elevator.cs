using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : Interactable
{
    [SerializeField]
    private GameObject elevator;
    private bool elevatorOpen;
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
        elevatorOpen = !elevatorOpen;
        elevator.GetComponent<Animator>().SetBool("IsOpen", elevatorOpen);

    }
}
