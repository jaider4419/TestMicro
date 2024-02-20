using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter2 : Interactable
{
    [SerializeField]
    private GameObject Secondcounter;
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
        Secondcounter.GetComponent<Animator>().SetBool("IsOpen", counterOpen);

    }
}