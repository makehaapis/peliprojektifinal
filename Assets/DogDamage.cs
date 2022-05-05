using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DogDamage : MonoBehaviour
{
    [SerializeField] AudioSource dogDamage;
    [SerializeField] AudioSource dogPotion;
    public int maxHealth = 100;
    public int currentHealth;

    public PlayerHealthBar healthBar;

    public float damageTimeout = 1f;
    private bool canTakeDamage = true;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void AddHealth(int health)
    {
        currentHealth += health;
        healthBar.SetHealth(currentHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (canTakeDamage && collision.CompareTag("Enemy"))
        {
            TakeDamage(20);
            dogDamage.Play();
            StartCoroutine(damageTimer());
        }

        if (collision.CompareTag("DogFood") && currentHealth != maxHealth)
        {
            AddHealth(20);
            Destroy(collision.gameObject);
            dogPotion.Play();
        }
    }
    private IEnumerator damageTimer()
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(damageTimeout);
        canTakeDamage = true;
    }

}
