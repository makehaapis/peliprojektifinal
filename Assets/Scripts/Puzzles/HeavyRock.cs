using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyRock : MonoBehaviour
{
    public GameObject objectToDistroy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(objectToDistroy);
        }
    }
}
