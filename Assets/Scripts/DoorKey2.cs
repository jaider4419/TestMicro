using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenKey : Interactable
{

    public bool inTrigger;
    public GameObject greenKey;


    void Update()
    {
        if (inTrigger)
        {

            {
                testingGreen.greenKey = true;
                Destroy(this.gameObject);
            }
        }
    }

    protected override void Interact()

    {
        inTrigger = true;
    }
}