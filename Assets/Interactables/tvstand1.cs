using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tvstand1 : Interactable
{
    [SerializeField]
    private GameObject Tvstand1;
    private bool tvstand1Open;
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
        tvstand1Open = !tvstand1Open;
        Tvstand1.GetComponent<Animator>().SetBool("IsOpen", tvstand1Open);

    }
}
