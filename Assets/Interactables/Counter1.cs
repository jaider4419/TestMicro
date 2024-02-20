using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter1 : Interactable
{
    [SerializeField]
    private GameObject Firstcounter;
    private bool counterOpen;
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
        Debug.Log("Opened");
        counterOpen = !counterOpen;
        Firstcounter.GetComponent<Animator>().SetBool("IsOpen", counterOpen);

    }
}