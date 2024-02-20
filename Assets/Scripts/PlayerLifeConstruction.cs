using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerLifeConstruction : MonoBehaviour
{
    public float threshold;

    private void FixedUpdate()
    {
        if (transform.position.y < threshold)
        {
            transform.position = new Vector3(39.56f, 29.67f, -18.239f);
        }
    }

}
