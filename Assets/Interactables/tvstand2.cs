using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tvstand2 : Interactable
{
    [SerializeField]
    private GameObject Tvstand2;
    private bool tvstand2Open;
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
        tvstand2Open = !tvstand2Open;
        Tvstand2.GetComponent<Animator>().SetBool("IsOpen", tvstand2Open);

    }
}
