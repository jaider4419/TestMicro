using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BreakableWall : Interactable
{
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
        Debug.Log("Wall breaking....." + gameObject.name);
        Destroy(gameObject);

    }
}