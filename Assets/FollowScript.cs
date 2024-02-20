using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float chaseRange = 10f; // Range within which the enemy will start chasing the player
    public float moveSpeed = 5f; // Speed at which the enemy moves

    private Rigidbody enemyRb;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (player == null) // If player is null, find the player
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        if (player != null)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            if (distanceToPlayer <= chaseRange)
            {
                // Enemy is within chase range, so move towards the player
                Vector3 direction = (player.position - transform.position).normalized;
                enemyRb.MovePosition(transform.position + direction * moveSpeed * Time.deltaTime);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            // Restart the scene when the enemy collides with the player
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

