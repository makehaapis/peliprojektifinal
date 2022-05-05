using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearChasing : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;

    public float close;
    private float distance;
    public bool chasing;

    private bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundLayer;

    public float runningspeed;

    public float extraValue;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        chasing = false;
    }

    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.3f, groundLayer);

        if (distance <= close)
        {
            chasing = true;
        }

        if (chasing == true)
        {
            Chase();
        }

        if (isGrounded == false)
        {
            print(Physics.gravity);
            rb.gravityScale = 5;
        }
    }

    private void Chase()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, transform.position.y, transform.position.z), runningspeed * Time.deltaTime);
    }

}
