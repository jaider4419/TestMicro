using UnityEngine;

public class VentInteraction : MonoBehaviour
{
    public AudioClip needKeycardAudio;
    public AudioClip unlockSound;
    public GameObject keycardObject;
    public GameObject ventObject;
    public float interactDistance = 3f;

    private AudioSource audioSource;
    private bool hasKeycard = false;
    private bool isInteractable = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (isInteractable && Input.GetKeyDown(KeyCode.E))
        {
            if (hasKeycard)
            {
                if (ventObject != null)
                {
                    // Play unlock sound
                    if (unlockSound != null)
                    {
                        audioSource.PlayOneShot(unlockSound);
                    }

                    // Destroy vent object
                    Destroy(ventObject);
                }

                // Optionally, you may want to destroy the keycard object as well
                if (keycardObject != null)
                {
                    Destroy(keycardObject);
                }

                // Player can now go through the vent
            }
            else
            {
                if (needKeycardAudio != null)
                {
                    // Play "need keycard" audio
                    audioSource.PlayOneShot(needKeycardAudio);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteractable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteractable = false;
        }
    }

    public void SetHasKeycard(bool value)
    {
        hasKeycard = value;
    }
}

