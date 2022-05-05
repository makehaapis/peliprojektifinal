using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTrigger : MonoBehaviour
{

    public GameObject key;

    void Start()
    {
        key.gameObject.SetActive(false);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Circle")
        {
            key.gameObject.SetActive(true);
        }
    }
}
