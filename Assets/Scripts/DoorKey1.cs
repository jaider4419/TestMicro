using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedKey : Interactable
{

    public bool inTrigger;
    public GameObject doorKey;


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
        inTrigger = true;
      }

}
