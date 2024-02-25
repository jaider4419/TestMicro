using UnityEngine;

public class StopBackgroundMusic : MonoBehaviour
{
    private void Start()
    {
        // Find the GameObject with the "BackgroundMusic" tag
        GameObject backgroundMusic = GameObject.FindWithTag("BackgroundMusic");

        // If the GameObject is found, stop the AudioSource
        if (backgroundMusic != null)
        {
            AudioSource audioSource = backgroundMusic.GetComponent<AudioSource>();
            if (audioSource != null && audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}

