using UnityEngine;

public class AudioController : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public AudioSource audioSource; // Reference to the AudioSource component
    public float maxVolumeDistance = 10f; // Maximum distance for full volume
    public float minVolumeDistance = 2f; // Minimum distance for minimum volume
    public float maxVolume = 1f; // Maximum volume
    public float minVolume = 0.1f; // Minimum volume

    void Start()
    {
        // Set the initial volume to minimum
        audioSource.volume = minVolume;
    }

    void Update()
    {
        // Calculate the distance between the player and the object
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Calculate the volume based on the distance
        float volume = Mathf.Clamp01(1 - (distanceToPlayer - minVolumeDistance) / (maxVolumeDistance - minVolumeDistance));

        // Interpolate between minVolume and maxVolume based on volume
        audioSource.volume = Mathf.Lerp(minVolume, maxVolume, volume);
    }
}

