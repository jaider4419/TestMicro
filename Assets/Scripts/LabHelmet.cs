using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LabHelmet : Interactable
{


    public GameObject fartingthing;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void Interact()
    {
        SceneManager.LoadScene("FlatBeforeElevator");
        Destroy(gameObject);
        Destroy(fartingthing);
    }
}
