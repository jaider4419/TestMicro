using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : Interactable
{
    public GameObject destroyedVersion;

    protected override void  Interact()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }


}