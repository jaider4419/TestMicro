using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerFirst : Interactable
{
    [SerializeField]
    private GameObject Drawer1;
    private bool drawerOpen;
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
        drawerOpen = !drawerOpen;
        Drawer1.GetComponent<Animator>().SetBool("IsOpen", drawerOpen);

    }
}
