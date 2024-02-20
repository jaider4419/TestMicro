using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : Interactable
{

    public bool inTrigger;
    public GameObject doorKey;

    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                testing.doorKey = true;
                Destroy(this.gameObject);
            }
        }
    }

    protected override void Interact()

    {
        if (inTrigger)
        {
            Debug.Log("Press E to take key");
        }
    }
}