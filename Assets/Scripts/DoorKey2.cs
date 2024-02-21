using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenKey : Interactable
{

    public bool inTrigger;
    public GameObject greenKey;

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
                testingGreen.greenKey = true;
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