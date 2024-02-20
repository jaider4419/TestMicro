using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUILong : MonoBehaviour
{
    public GameObject uiObject;
    public AudioSource audioSource;
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
        }
    }

    IEnumerator WaitForSec()
    {

        yield return new WaitForSeconds(10);
        Destroy(uiObject);
        Destroy(gameObject);
    }
}
