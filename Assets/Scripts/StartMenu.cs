using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    [SerializeField] RectTransform fader;

    private void Start()
    {

    }

    public void StartGame()
    {
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        };

    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("(You have exited the game");
    }

    public void SettingsButton()
    {
        
    }
}
