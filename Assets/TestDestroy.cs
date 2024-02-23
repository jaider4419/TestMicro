using UnityEngine;

public class TestDestroy : Interactable
{
    public float breakForce = 10f;
    public float breakRadius = 1f;
    public float destroyDelay = 5f; // Delay before destroying the wall

    private bool isBroken = false;
    public AudioSource Wall;

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
    }

    protected override void Interact()
    {
        BreakWall();
        Wall.Play();
    }
}


