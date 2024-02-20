using UnityEngine;

public class Ladder : MonoBehaviour
{
    public float climbSpeed = 3f;

    public bool isPlayerInRange = false;

    void Update()
    {
        if (isPlayerInRange)
        {
            float verticalInput = Input.GetAxis("Vertical");
            Climb(verticalInput);
        }
    }

    void Climb(float input)
    {
        Vector3 movement = new Vector3(0f, input * climbSpeed * Time.deltaTime, 0f);
        transform.Translate(movement);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }
}


