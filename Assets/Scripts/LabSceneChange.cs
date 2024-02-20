using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LabSceneChange : Interactable
{
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
        Debug.Log("Changing Scene with.....: " + gameObject.name);
        Destroy(gameObject);
        SceneManager.LoadScene("oki");

    }
}