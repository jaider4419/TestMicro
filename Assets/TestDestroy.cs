using UnityEngine;

public class KinematicToggle : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component attached to this GameObject
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check if the player presses the "E" key
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Toggle the isKinematic property
            rb.isKinematic = !rb.isKinematic;
            Debug.Log("destroying");
        }
    }
}
