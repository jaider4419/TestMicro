using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crane : Interactable
{
    [SerializeField]
    private GameObject CraneHinge;
    private bool IsMoving;
    public AudioSource audiosource;
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
        IsMoving = !IsMoving;
        CraneHinge.GetComponent<Animator>().SetBool("IsMoving", IsMoving);
        audiosource.Play();

    }
}
