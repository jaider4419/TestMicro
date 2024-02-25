using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public AudioClip audioClip; // Audio clip to play
    public GameObject uiObject; // Reference to the GameObject to show
    public float displayTime = 3f; // Time to display UI in seconds
    public float audioStopDelay = 2f; // Delay before stopping audio after the player exits the trigger

    private AudioSource audioSource;
    private bool playerInsideTrigger = false;
    private bool hasEntered = false;
    private bool exitingTrigger = false;
    

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Deactivate the UI object at the beginning
        uiObject.SetActive(false);
    }

    void Update()
    {
        // If the player is inside the trigger and the audio is not playing
        if (playerInsideTrigger && !hasEntered)
        {
            // Play the audio clip
            audioSource.Play();
            hasEntered = true;

            // Show the UI object
            uiObject.SetActive(true);

            // Start counting down the display timer
            Invoke("HideUI", displayTime);
        }

        // If the player exits the trigger and is not currently in the process of stopping audio
        if (!playerInsideTrigger && hasEntered && !exitingTrigger)
        {
            // Start the delay before stopping audio
            exitingTrigger = true;
            Invoke("StopAudio", audioStopDelay);
        }
    }

    // When the player enters the trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasEntered)
        {
            playerInsideTrigger = true;
        }
    }

    // When the player exits the trigger
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && hasEntered)
        {
            playerInsideTrigger = false;
            exitingTrigger = false; // Reset exitingTrigger flag

            // If the player re-enters the trigger within the delay, cancel the stop audio operation
            CancelInvoke("StopAudio");
        }
    }

    // Method to hide UI
    void HideUI()
    {
        // Hide the UI object
        uiObject.SetActive(false);
    }

    // Method to stop audio
    void StopAudio()
    {
        // Stop the audio clip
        audioSource.Stop();
        hasEntered = false; // Reset hasEntered flag when audio stops
    }
}







