using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testingRed : Interactable
{

    public static bool redKey;
    public bool open;
    public bool close;
    public bool inTrigger;
    public AudioSource Openyay;
    public AudioSource NeedAkeycard;

    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    void Update()
    {
        if (inTrigger)
        {
            if (close)
            {
                if (redKey)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        open = true;
                        close = false;
                    }
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    close = true;
                    open = false;
                }
            }
        }

        if (open)
        {
            Destroy(gameObject);
        }
        else
        {
            var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * 200);
            transform.rotation = newRot;

        }
    }

    protected override void Interact()
    {
        if (inTrigger)
        {
            if (open)
            {
                Openyay.Play();
                Debug.Log("Press E to close");
            }
            else
            {
                if (redKey)
                {
                    Debug.Log("Press E to open");
                }
                else
                {
                    NeedAkeycard.Play();
                    Debug.Log("Need a key!");
                }


            }

        }

    }

}

