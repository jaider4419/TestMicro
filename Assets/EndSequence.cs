using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSequence : MonoBehaviour
{


    public string scenename;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene(scenename);
        }
    }
}
