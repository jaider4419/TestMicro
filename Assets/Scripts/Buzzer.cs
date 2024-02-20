using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buzzer : Interactable
{

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
        audiosource.Play();
    }
}
