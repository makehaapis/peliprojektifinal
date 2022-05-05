using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogRunning : MonoBehaviour
{

    public Animator animator;

    public float oldPosition;
    public bool movingRight = false;
    public bool movingLeft = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > oldPosition)
        {
            movingRight = true;
            movingLeft = false;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            animator.SetBool("isRunning", true);
        }

        else if (transform.position.x < oldPosition)
        {
            movingRight = false;
            movingLeft = true;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            animator.SetBool("isRunning", true);
        }

        else if (transform.position.x == oldPosition)
        {
            animator.SetBool("isRunning", false);
        }
    }

    void FixedUpdate()
    {
        oldPosition = transform.position.x;
    }
}
