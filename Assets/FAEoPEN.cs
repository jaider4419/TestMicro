using UnityEngine;

public class FAEoPen : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        animator.Play("Cube", 0, 0); // Replace "YourAnimationName" with the name of your animation clip
    }
}

