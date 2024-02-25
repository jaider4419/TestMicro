using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneAudio : MonoBehaviour
{

    public AudioSource audiosource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            audiosource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            audiosource.Stop();
        }
    }
}
