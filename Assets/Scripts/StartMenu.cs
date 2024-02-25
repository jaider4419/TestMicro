using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    private void Start()
    {
        // Ensure the cursor is visible and unlocked when the main menu starts
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void StartGame()
    {
        // Load the next scene in the build order
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitButton()
    {
        // Exit the application
        Application.Quit();
        Debug.Log("You have exited the game");
    }

    public void SettingsButton()
    {
        // You can implement settings functionality here
    }
}
