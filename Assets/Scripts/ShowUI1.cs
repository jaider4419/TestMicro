using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI1 : MonoBehaviour
{
    public GameObject uiObject;
    public AudioSource audioSource;
    public AudioSource audioSource2;
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
        }
    }

    IEnumerator WaitForSec()
    {

        yield return new WaitForSeconds(5);
        Destroy(uiObject);
        Destroy(gameObject);
    }
}
