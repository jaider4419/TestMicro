using UnityEngine;

public class Keycard : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Call the ScanKeycard function of the KeycardScanner script attached to the keycard scanner
            FindObjectOfType<KeycardScanner>().ScanKeycard();
            // Destroy the keycard after it's been picked up
            Destroy(gameObject);
        }
    }
}

