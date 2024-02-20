using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeScript : Interactable
{
    [SerializeField]
    private GameObject Fridge;
    private bool fridgeOpen;
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
        fridgeOpen = !fridgeOpen;
        Fridge.GetComponent<Animator>().SetBool("IsOpen", fridgeOpen);

    }
}