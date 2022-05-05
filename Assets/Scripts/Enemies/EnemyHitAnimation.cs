using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitAnimation : MonoBehaviour
{
    [SerializeField] AudioSource deathSound;
    private SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            StartCoroutine(FlashRed());
            deathSound.Play();   
        }
    }
    private IEnumerator FlashRed()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        sprite.color = Color.white;
    }
}
