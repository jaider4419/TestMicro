using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioClip walkingSound;
    public AudioClip runningSound;

    private AudioSource audioSource;
    private bool isWalking;
    private bool isRunning;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        // Check if both space and another key are pressed simultaneously
        if (Input.GetKey(KeyCode.Space) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)))
        {
            isWalking = false;
            return;
        }

        // Check for movement keys (WASD)
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (!isWalking)
            {
                PlayFootstepSound(walkingSound);
                isWalking = true;
            }
        }
        else
        {
            isWalking = false;
        }

        // Check for running (Left Shift)
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isRunning = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isRunning = false;
        }

        if (isRunning && !audioSource.isPlaying)
        {
            PlayFootstepSound(runningSound);
        }
    }

    private void PlayFootstepSound(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
