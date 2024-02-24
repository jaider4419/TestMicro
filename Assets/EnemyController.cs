using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float moveSpeed = 3f; // Speed at which the enemy moves
    public float stoppingDistance = 2f; // Distance at which the enemy stops following the player
    public float reloadDelay = 1f; // Delay before reloading the scene after player collision
    public Collider boundaryCollider; // Collider defining the boundary where the enemy stops following
    public string nextSceneName;

    private bool isFollowingPlayer = false;

    void Update()
    {
        if (player == null)
            return; // Do nothing if the player is not assigned

        // Calculate the distance between the enemy and the player
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Check if the player is within the boundary collider
        bool playerWithinBoundary = boundaryCollider.bounds.Contains(player.position);

        if (distanceToPlayer < stoppingDistance || !playerWithinBoundary)
        {
            isFollowingPlayer = false; // Stop following the player if within stopping distance or outside boundary
        }
        else
        {
            isFollowingPlayer = true; // Start following the player if beyond stopping distance and within boundary

            // Move the enemy towards the player
            transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ReloadScene();
        }
    }

    void ReloadScene()
    {
        // Reload the active scene
        SceneManager.LoadScene(nextSceneName);
    }
}
