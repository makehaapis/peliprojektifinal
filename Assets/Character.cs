using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    //public float MovementSpeed = 1;
    public float JumpForce = 1;

    private Rigidbody2D rb;

    public Transform keyFollowPoint;
    public Key followingKey;

    public Animator animator;

    public float speed = 5;
    private float direction = 0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        //Escape Quit
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        // MOVEMENT
        //var movement = Input.GetAxis("Horizontal");
        //transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        //animator.SetFloat("Speed", Mathf.Abs(movement));
        //NEW MOVEMENT
        direction = Input.GetAxis("Horizontal");

        if (direction > 0f)
        {
            rb.velocity = new Vector2(direction * speed, rb.velocity.y);
            transform.localScale = new Vector2(0.7882041f, 0.7882041f);
        }
        else if (direction < 0f)
        {
            rb.velocity = new Vector2(direction * speed, rb.velocity.y);
            transform.localScale = new Vector2(-0.7882041f, 0.7882041f);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        animator.SetFloat("Speed", Mathf.Abs(direction));

        // JUMPING
        if (Input.GetKeyDown(KeyCode.UpArrow) && Mathf.Abs(rb.velocity.y) < 0.001f) //0.001f
        {
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Lvl0tolvl2")
        {
            SceneManager.LoadScene(2);
            PlayerPrefs.SetInt("reachedLevel", 2);
            PlayerPrefs.Save();
        }
        else if (collision.tag == "Lvl2toLvl3")
        {
            SceneManager.LoadScene(3);
            PlayerPrefs.SetInt("reachedLevel", 3);
            PlayerPrefs.Save();
        }

        else if (collision.tag == "Lvl3toLv4")
        {
            SceneManager.LoadScene(4);
            PlayerPrefs.SetInt("reachedLevel", 4);
            PlayerPrefs.Save();
        }

        else if (collision.tag == "Lvl4toLvl5")
        {
            SceneManager.LoadScene(5);
            PlayerPrefs.SetInt("reachedLevel", 5);
            PlayerPrefs.Save();
        }
    }

}
