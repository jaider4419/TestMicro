using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedsideTable1 : Interactable
{
    [SerializeField]
    private GameObject group1;
    private bool group1Open;
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
        group1Open = !group1Open;
        group1.GetComponent<Animator>().SetBool("IsOpen" , group1Open);

    }
}
