using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedsideTable2 : Interactable
{
    [SerializeField]
    private GameObject group2;
    private bool group2Open;
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
        Debug.Log("Opened?");
        group2Open = !group2Open;
        group2.GetComponent<Animator>().SetBool("IsOpen", group2Open);

    }
}