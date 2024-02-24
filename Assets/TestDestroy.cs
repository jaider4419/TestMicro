using UnityEngine;

public class TestDestroy : Interactable
{
    public float breakForce = 10f;
    public float breakRadius = 1f;
    public float destroyDelay = 5f; // Delay before destroying the wall

    private bool isBroken = false;
    private bool audioPlayed = false; // Track if the audio has been played

    public AudioSource WallAudio;
    public AudioSource BreakAudio;

    void BreakWall()
    {
        if (isBroken) return; // If the wall is already broken, don't break it again

        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rb in rigidbodies)
        {
            rb.isKinematic = false;
            rb.AddExplosionForce(breakForce, transform.position, breakRadius);
        }

        // Optionally, you can destroy the entire wall after breaking
        Destroy(gameObject, destroyDelay); // Destroy the wall after a delay
        isBroken = true; // Set the wall as broken

        // Play the audio only if it hasn't been played before
        if (!audioPlayed)
        {
            WallAudio.Play();
            BreakAudio.Play();
            audioPlayed = true; // Set audioPlayed to true to prevent playing again
        }
    }

    protected override void Interact()
    {
        BreakWall();
    }
}





