using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private InputController input = null;
    [SerializeField, Range(0f, 100f)] private float maxSpeed = 4f;
    [SerializeField, Range(0f, 100f)] private float maxAcceleration = 35f;
    [SerializeField, Range(0f, 100f)] private float maxAirAcceleration = 20f;

    [SerializeField] private AudioSource footStepAudioSource = default;
    [SerializeField] private AudioClip[] footStepClips = default;
    [SerializeField] private float footstepTimer = 0;

    private Vector2 velocity;
    private Vector2 direction;
    private Vector2 desiredVelocity;
    private Rigidbody2D rb2d;
    private Ground ground;
    private Slope slope;
    private float maxSpeedChange;
    private float accelaration;
    private bool onGround;
    private bool onSlope;

    public Animator animator;

    // Start is called before the first frame update
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        ground = GetComponent<Ground>();
        slope = GetComponent<Slope>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = input.RetrieveMoveInput();
        Handle_Footsteps();
        desiredVelocity = new Vector2(direction.x, 0f) * Mathf.Max(maxSpeed - ground.GetFriction(), 0);

        //run animation
        float moving = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(moving));
    }

    private void Handle_Footsteps()
    {
        if (!ground.GetonGround()) return;
        if (direction.x == 0) return;

        footstepTimer -= Time.deltaTime;

        if (footstepTimer <= 0)
        {
            footStepAudioSource.PlayOneShot(footStepClips[Random.Range(0, footStepClips.Length - 1)]);
            footstepTimer = 0.5f;
        }
    }

    private void FixedUpdate()
    {
        onGround = ground.GetonGround();
        onSlope = slope.GetOnSlope();
        velocity = rb2d.velocity;

        accelaration = onGround ? maxAcceleration : maxAirAcceleration;
        maxSpeedChange = accelaration * Time.deltaTime;
        velocity.x = Mathf.MoveTowards(velocity.x, desiredVelocity.x, maxSpeedChange);
        if (rb2d.velocity.x > 0)
        {
            
        }
        if (onGround && !onSlope)
        {
            rb2d.velocity = velocity;
        }
        else if (onGround && onSlope)
        {
            rb2d.velocity = velocity;
        }
        else
        {
            rb2d.velocity = velocity;
        }

    }
}