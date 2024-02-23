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

    void Update()
    {
        if (inTrigger)
        {
            if (close)
            {
                if (redKey)
                {
                    {
                        Openyay.Play();
                        open = true;
                        close = false;
                    }
                }
            }
            else
            {
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
            if (close)
            {
                if (redKey)
                {
                    {
                        Openyay.Play();
                        open = true;
                        close = false;
                    }
                }
            }
            else
            {
                {
                    close = true;
                    open = false;
                }
            }
        }

    }
}

