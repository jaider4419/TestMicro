using UnityEngine;

public class KeycardScanner : MonoBehaviour
{
    public GameObject ventCollider; // Reference to the vent's BoxCollider

    private bool keycardScanned = false; // Flag to track if the keycard has been scanned

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider entering the trigger is the player and if the keycard has been scanned
        if (other.CompareTag("Player") && keycardScanned)
        {
            // Allow the player to pass through the vent by disabling its collider
            ventCollider.SetActive(false);
            Debug.Log("Vent collider disabled. Player can pass through.");
        }
    }

    // Function to be called when the keycard is scanned
    public void ScanKeycard()
    {
        // Set the flag to true indicating that the keycard has been scanned
        keycardScanned = true;
        Debug.Log("Keycard scanned.");
    }
}

