using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float crouchHeight = 0.5f; // Height when crouched
    public float standingHeight = 2f; // Height when standing
    public bool isCrouching = false; // Flag to track crouch state
    public LayerMask ventLayer; // Layer mask for vent objects
    public KeyCode crouchKey = KeyCode.LeftControl; // Key to crouch

    private CharacterController characterController; // Reference to the CharacterController component

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // Check if the player is pressing the crouch key
        if (Input.GetKeyDown(crouchKey))
        {
            ToggleCrouch();
        }
    }

    private void ToggleCrouch()
    {
        // Check if the player is currently crouching and if they're inside a vent
        if (isCrouching && IsPlayerInsideVent())
        {
            // Player is crouching inside a vent, do not allow uncrouching
            return;
        }

        isCrouching = !isCrouching;

        // Adjust character height based on crouch state
        characterController.height = isCrouching ? crouchHeight : standingHeight;

        // Update character controller center to prevent clipping
        characterController.center = Vector3.up * (characterController.height / 2f);
    }

    private bool IsPlayerInsideVent()
    {
        // Check if the player's collider is colliding with any objects on the vent layer
        Collider[] colliders = Physics.OverlapSphere(transform.position, characterController.radius, ventLayer);
        foreach (Collider collider in colliders)
        {
            // You may need to adjust this check based on your vent objects
            if (collider.CompareTag("Vent"))
            {
                return true;
            }
        }
        return false;
    }
}

