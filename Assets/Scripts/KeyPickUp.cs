using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyPickUp : Interactable
{
    // Start is called before the first frame update
    public GameObject keyimage;
    public GameObject keyistrue;
    public bool isplayer;
    void Start()
    {
        isplayer = false;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isplayer = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isplayer = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (isplayer)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                keyimage.SetActive(true);
                keyistrue.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
}

