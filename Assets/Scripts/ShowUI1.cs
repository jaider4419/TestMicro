using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI1 : MonoBehaviour
{
    public GameObject uiObject;
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public AudioSource Music;
    public AudioSource Alarms;
    void Start()
    {
        uiObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
            audioSource.Play();
            audioSource2.Play();
            Music.Play();
            Alarms.Play();
        }
    }

    private void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            audioSource.Stop();
            Music.Stop();
        }
    }

    IEnumerator WaitForSec()
    {

        yield return new WaitForSeconds(5);
    }
    public void end()
    {
        Destroy(uiObject);
    }
}
