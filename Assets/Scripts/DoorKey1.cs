using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey1 : Interactable
{

    public bool inTrigger;
    public GameObject redKey;


    void Update()
    {
        if (inTrigger)
        {

            {
                testingRed.redKey = true;
                Destroy(this.gameObject);
            }
        }
    }

    protected override void Interact()

    {
        (inTrigger) = true;
    }
}