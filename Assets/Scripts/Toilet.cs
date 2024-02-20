using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet : Interactable
{
    [SerializeField]
    private GameObject Potty;
    private bool IsOpen;
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
        IsOpen = !IsOpen;
        Potty.GetComponent<Animator>().SetBool("IsOpen", IsOpen);

    }
}
