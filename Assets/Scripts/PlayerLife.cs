using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerLife : MonoBehaviour
{
    public float threshold;

    private void FixedUpdate()
    {
        if (transform.position.y < threshold)
        {
            transform.position = new Vector3(43.32f, 1.59f, -72.13f);
        }
    }

}
