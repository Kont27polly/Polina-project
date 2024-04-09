using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Animator animator;
    // Start is called before the first frame update
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement =
            new Vector3(horizontalInput, 0f, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        if (horizontalInput > 0)
        {
            animator.SetBool("Run", true);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (horizontalInput < 0)
        {
            animator.SetBool("Run", true);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            animator.SetBool("Run", false);
        }
    }
}