using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAttackAnimation : MonoBehaviour
{
    private SpriteRenderer sprite;
    public Animator animator;
    public bool hit;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        hit = false;
    }

    void Update()
    {
        if (hit == true)
        {
            animator.SetBool("Attack", true);
        }
        else animator.SetBool("Attack", false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(FlashRed());
            hit = true;
        }
    }

    private IEnumerator FlashRed()
    {
        yield return new WaitForSeconds(0.4f);
        hit = false;
    }
}
