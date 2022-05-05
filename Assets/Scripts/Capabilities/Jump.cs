using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private InputController input = null;
    [SerializeField, Range(0f, 100f)] private float jumpHeight = 3f;
    [SerializeField, Range(0, 5)] private int maxAirJumps = 1;
    [SerializeField, Range(0f, 10f)] private float downwardMovementMultiplier = 3f;
    [SerializeField, Range(0f, 10f)] private float upwardMovementMultiplier = 2f;


    private Rigidbody2D rb2d;
    private Ground ground;
    private Vector2 velocity;

    private int jumpPhase;
    private float defaultGravityScale;

    private bool desiredJump;


    private bool onGround;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public Animator animator;

    // Start is called before the first frame update
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        ground = GetComponent<Ground>();

        defaultGravityScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        desiredJump |= input.RetrieveJumpInput();
        velocity = rb2d.velocity;
        if (onGround)
        {
            jumpPhase = 0;
        }
        if (desiredJump)
        {
            desiredJump = false;
            JumpAction();
        }
        if (rb2d.velocity.y > 0)
        {
            rb2d.gravityScale = upwardMovementMultiplier;
        }
        else if (rb2d.velocity.y < 0)
        {
            rb2d.gravityScale = downwardMovementMultiplier;
        }
        else if (rb2d.velocity.y == 0)
        {
            rb2d.gravityScale = defaultGravityScale;
        }

        rb2d.velocity = velocity;


        onGround = Physics2D.OverlapCircle(groundCheck.position, 0.45f, groundLayer);
        //jump animation
        animator.SetBool("Jump", onGround);
    }
    private void FixedUpdate()
    {
        onGround = ground.GetonGround();
    }
    private void JumpAction()
    {
        if (onGround || jumpPhase < maxAirJumps)
        {
            jumpPhase += 1;
            float jumpSpeed = Mathf.Sqrt(-2f * Physics2D.gravity.y * jumpHeight);
            if (velocity.y > 0f)
            {
                jumpSpeed = Mathf.Max(jumpSpeed - velocity.y, 0f);
            }
            velocity.y += jumpSpeed;

        }
    }


}