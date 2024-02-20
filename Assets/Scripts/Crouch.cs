using UnityEngine;

public class Crouch : MonoBehaviour
{
    public bool isCrouching = false;
    public bool isInVent = false;

    // Update is called once per frame
    void Update()
    {
        // Check for input to toggle crouch
        if (Input.GetKeyDown(KeyCode.C))
        {
            ToggleCrouch();
        }

        // Check if the player is trying to uncrouch while in the vent
        if (isInVent && isCrouching && Input.GetKeyDown(KeyCode.C))
        {
            // Do nothing (Prevent uncrouching)
            Debug.Log("Cannot uncrouch in vent!");
        }
    }

    void ToggleCrouch()
    {
        // Toggle crouch state
        isCrouching = !isCrouching;

        // Adjust player's height based on crouch state (adjust as per your player's setup)
        if (isCrouching)
        {
            transform.localScale = new Vector3(1, 0.5f, 1); // Example scale for crouching
        }
        else
        {
            transform.localScale = new Vector3(1, 1f, 1); // Example scale for standing
        }
    }

    // Assuming you have some mechanism to detect when the player enters/exits the vent
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Vent"))
        {
            isInVent = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Vent"))
        {
            isInVent = false;
        }
    }
}
