using UnityEngine;

public class TestCrotch : MonoBehaviour
{
    public float originalHeight = 2f; // Original height of the player controller
    public float crouchHeight = 1f; // Height of the player controller when crouching

    private bool isCrouching = false; // Flag to track if player is currently crouching
    private bool isInVent = false; // Flag to track if player is currently in a vent

    void Update()
    {
        // Check if 'C' key is pressed
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Toggle crouch state
            isCrouching = !isCrouching;

            // Adjust controller height based on crouch state
            if (isCrouching)
            {
                transform.localScale = new Vector3(transform.localScale.x, crouchHeight, transform.localScale.z);
            }
            else
            {
                // Check if player is not in vent before standing up
                if (!isInVent)
                {
                    transform.localScale = new Vector3(transform.localScale.x, originalHeight, transform.localScale.z);
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the player enters a vent
        if (other.CompareTag("Vent"))
        {
            isInVent = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the player exits a vent
        if (other.CompareTag("Vent"))
        {
            isInVent = false;
        }
    }
}
